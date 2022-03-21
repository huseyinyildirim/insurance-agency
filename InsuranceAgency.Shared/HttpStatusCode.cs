namespace InsuranceAgency.Shared
{
    public static class HttpStatusCode
    {
        /**
     * İstek başarılı alınmış ve cevap başarılı verilmiştir.
     */
        public const int OK = 200;

        /**
         * İstek başarılı olmuş ve sunucuda yeni bir kaynak yaratılmıştır.
         */
        public const int CREATED = 201;

        /**
         * Sunucu isteği kabul etti ancak henüz işlemedi.
         */
        public const int ACCEPTED = 202;

        /**
         * İstek başarılı alınmış ancak geri içerik döndürülmemektedir.
         */
        public const int NO_CONTENT = 204;

        /**
         * Bir kaynağın (veya sayfanın) kalıcı olarak başka bir yere taşındığını bildirir ve o yere yönlendirme sağlar.
         */
        public const int MOVED_PERMANENTLY = 301;

        /**
         * İstek hatalı (isteğin yapısı hatalı) olduğu belirtilir.
         */
        public const int BAD_REQUEST = 400;

        /**
         * Yetkisi olmadığını belirtir.
         */
        public const int UNAUTHORIZED = 401;

        /**
         * Kaynağın yasaklandığını belirtir.
         */
        public const int FORBIDDEN = 403;

        /**
         * İstek yapılan kaynağın (veya sayfanın) bulunamadığını belirtir.
         */
        public const int NOT_FOUND = 404;

        /**
         * Sunucu , HTTP Method'u kabul etmiyor.
         */
        public const int METHOD_NOT_ALLOWED = 405;

        /**
         * Sunucuda bir hata oluştu ve istek karşılanamadı.
         */
        public const int INTERNAL_SERVER_ERROR = 500;
    }
}
