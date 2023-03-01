using FluentValidation.Results;

namespace Sis.Utils
{
   public abstract class Alert
   {
      public static DialogResult Show(string caption, ValidationResult result)
      {
         return MessageBox.Show
         (
            string.Join(Environment.NewLine, result.Errors.Select(c => c.ErrorMessage).ToList()),
            caption,
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
         );
      }
   }
}
