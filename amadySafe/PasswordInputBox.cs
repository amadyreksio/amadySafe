using System;
using System.Windows.Forms;

public static class PasswordInputBox
{
	public static string Show(string prompt, string title)
	{
		Form promptForm = new Form()
		{
			Width = 300,
			Height = 150,
			FormBorderStyle = FormBorderStyle.FixedDialog,
			Text = title,
			StartPosition = FormStartPosition.CenterScreen
		};

		Label textLabel = new Label() { Left = 10, Top = 10, Text = prompt, Width = 260 };
		TextBox textBox = new TextBox() { Left = 10, Top = 30, Width = 260 };
		textBox.PasswordChar = '•';

		Button confirmation = new Button() { Text = "OK", Left = 200, Width = 70, Top = 60, DialogResult = DialogResult.OK };
		promptForm.AcceptButton = confirmation;

		promptForm.Controls.Add(textLabel);
		promptForm.Controls.Add(textBox);
		promptForm.Controls.Add(confirmation);

		return promptForm.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
	}
}
