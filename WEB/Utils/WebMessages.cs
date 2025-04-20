namespace WEB.Utils
{
    public static class WebMessages
    {
        private const string _successMessage = "İşlem başarılı!";
        private const string _errorMessage = "İşlem başarısız!";
        private const string _validationErrorMessage = "Lütfen aşağıdaki kurallara uyunuz!";
        private const string _sameNameValidationErrorMessage = "Bu isim kullanılmaktadır!";
        private const string _notFoundErrorMessage = "Sayfa bulanamadı!";

        public static string SuccessMessage { get => _successMessage; }
        public static string ErrorMessage { get => _errorMessage; }
        public static string ValidationErrorMessage { get => _validationErrorMessage; }
        public static string SameNameValidationErrorMessage { get => _sameNameValidationErrorMessage; }
        public static string NotFoundErrorMessage { get => _notFoundErrorMessage; }
    }
}
