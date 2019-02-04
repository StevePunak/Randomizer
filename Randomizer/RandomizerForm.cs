using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Randomizer
{
	public partial class Randomizer : Form
	{
		const int CASINO_SPEED = 50;
		const int BLINK_RATE = 500;
		const int BLINKS = 1;
		const int MIN_SPEED = 400;
		const int BUTTON_HEIGHT = 60;

		static readonly Color BLINK_BACK = Color.Green;
		static readonly Color BLINK_FORE = Color.White;

		Random _random;
		List<int> _numbersToGet;
		Timer _casinoTimer;
		Timer _blinkTimer;
		bool _backingOff;
		int _blinks;
		StackPanel flowLayout;

		public Randomizer()
		{
			InitializeComponent();
			flowLayout = new StackPanel();
			flowLayout.FlowDirection = FlowDirection.TopDown;
			flowLayout.Dock = DockStyle.Fill;
			flowLayout.AutoScroll = true;
			splitContainer1.Panel1.Controls.Add(flowLayout);
		}

		private void OnFormLoad(object sender, EventArgs args)
		{
			textMin.Text = 0.ToString();
			textMax.Text = 9.ToString();
			btnGrabIt.Enabled = false;
			btnGo.Enabled = true;
			textCasino.Text = String.Empty;

			flowLayout.WrapContents = false;
		}

		private void OnMaxMinTextChanged(object sender, EventArgs e)
		{
			int min, max;
			if( int.TryParse(textMin.Text, out min) && 
				int.TryParse(textMax.Text, out max) &&
				max > min)
			{
				btnGo.Enabled = true;
			}
			else
			{
				btnGo.Enabled = false;
			}
		}

		private void OnGoClicked(object sender, EventArgs args)
		{
			try
			{
				int min = int.Parse(textMin.Text);
				int max = int.Parse(textMax.Text);
				_numbersToGet = new List<int>();
				for(int x = min;x <= max;x++)
				{
					_numbersToGet.Add(x);
				}

				btnGo.Enabled = false;
				btnGrabIt.Enabled = true;
				textMin.Enabled = false;
				textMax.Enabled = false;
				flowLayout.Controls.Clear();

				_backingOff = false;

				_casinoTimer = new Timer();
				_casinoTimer.Interval = CASINO_SPEED;
				_random = new Random();
				_casinoTimer.Tick += OnCasinoTick;
				_casinoTimer.Enabled = true;
				_casinoTimer.Start();
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}

		}

		private void OnCasinoTick(object sender, EventArgs e)
		{
			int min, max;
			if(int.TryParse(textMin.Text, out min) && int.TryParse(textMax.Text, out max))
			{
				int got = _random.Next(_numbersToGet.Count);
				int value = _numbersToGet[got];
				textCasino.Text = value.ToString();
			}

			if(_backingOff)
			{
				int ms = _random.Next(_casinoTimer.Interval + CASINO_SPEED, _casinoTimer.Interval + (CASINO_SPEED * 2));
				_casinoTimer.Interval = ms;
				Debug.WriteLine(ms);
				if(_casinoTimer.Interval > MIN_SPEED)
				{
					_backingOff = false;
					_casinoTimer.Interval = CASINO_SPEED;
					int number = AddNumber();

					_numbersToGet.Remove(number);

					textCasino.BackColor = BLINK_BACK;
					StartBlinking();
				}
			}
		}

		private void OnGrabItClicked(object sender, EventArgs args)
		{
			try
			{
				btnGrabIt.Enabled = false;
				_backingOff = true;
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private int AddNumber()
		{
			int number = 0;

			try
			{
				Button label = new Button();
				label.Text = textCasino.Text;
				label.AutoSize = false;
				label.Height = BUTTON_HEIGHT;
				label.TextAlign = ContentAlignment.MiddleCenter;
				label.Font = textCasino.Font;
				label.ForeColor = Color.Green;
				label.BackColor = Color.White;
				// label.Dock = DockStyle.Top;
				flowLayout.Controls.Add(label);

				List<Control> controls = new List<Control>();
				foreach(Control control in flowLayout.Controls)
				{
					controls.Add(control);
				}

				number = int.Parse(label.Text);
			}
			catch(Exception e)
			{
				MessageBox.Show(e.Message);
			}

			return number;
		}

		void StartBlinking()
		{
			_casinoTimer.Enabled = false;

			_blinks = 0;
			_blinkTimer = new Timer();
			_blinkTimer.Interval = BLINK_RATE;
			_blinkTimer.Tick += OnBlinkTick;
			_blinkTimer.Enabled = true;
			_blinkTimer.Start();
		}

		private void OnBlinkTick(object sender, EventArgs e)
		{
			if(++_blinks > BLINKS)
			{
				_blinkTimer.Stop();
				textCasino.BackColor = Color.White;
				if(_numbersToGet.Count == 0)
				{
					_casinoTimer.Stop();
					btnGo.Enabled = true;
					btnGrabIt.Enabled = false;
				}
				else
				{
					_casinoTimer.Interval = CASINO_SPEED;
					_casinoTimer.Enabled = true;
					btnGrabIt.Enabled = true;
				}
			}
			else
			{
				if((_blinks % 2) == 0)
				{
					textCasino.BackColor = BLINK_BACK;
				}
				else
				{
					textCasino.BackColor = BLINK_FORE;
				}
			}


		}
	}
}
