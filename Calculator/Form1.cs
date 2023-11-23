namespace Calculator
{
    public partial class Form1 : Form
    {
        #region Constructors

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputTextBox.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Delete's a character from the user's input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            // Delete the value after selected position
            DeleteTextValue();

            // Focus the input text
            FocusInputText();
        }

        #endregion

        #region Number Methods

        /// <summary>
        /// Adds the 0 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberZeroButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 1 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberOneButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 2 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberTwoButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 3 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberThreeButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 4 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberFourButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 5 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberFiveButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 6 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberSixButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 7 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberSevenButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 8 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberEightButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the 9 character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void NumberNineButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the . character to the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void PointButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods

        /// <summary>
        /// Adds the percent character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PercentButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("%");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the divide character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event argument</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the multiply character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the minus character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void MinusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Adds the plus character to the text at the currently selected position
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void PlusButton_Click(object sender, EventArgs e)
        {
            // Insert the value in the user input text box at the currently selected position
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Calculatess the given equation in the user input
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        /// <summary>
        /// Calculates the given equation and outputs the answer to the user input text
        /// </summary>
        private void CalculateEquation()
        {
            //TODO: Finish

            // Focus the user input text
            FocusInputText();
        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputTextBox.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            // Remember selection start
            var selectionStart = this.UserInputTextBox.SelectionStart;

            // Set new text
            this.UserInputTextBox.Text = this.UserInputTextBox.Text.Insert(this.UserInputTextBox.SelectionStart, value);

            // Restore the selection start
            this.UserInputTextBox.SelectionStart = selectionStart + value.Length;

            // Set selection length to 1
            this.UserInputTextBox.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the character to the right of the selection start of the user input text box
        /// </summary>
        private void DeleteTextValue()
        {
            // If we dont have a value to delete, return
            if (this.UserInputTextBox.Text.Length < this.UserInputTextBox.SelectionStart + 1)
                return;

            // Remember the selection start
            var selectionStart = this.UserInputTextBox.SelectionStart;

            // Delete the character to the right of the selection
            this.UserInputTextBox.Text = this.UserInputTextBox.Text.Remove(this.UserInputTextBox.SelectionStart, 1);

            // Restore the selection
            this.UserInputTextBox.SelectionStart = selectionStart;

            // Set selection length to zero
            this.UserInputTextBox.SelectionLength = 0;
        }

        #endregion


    }
}