using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MiniShop.Shared.ResponseDTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        public bool IsSucceeded { get; set; }

        /// <summary>
        /// Bu metot, yapılan işlemin başarılı olduğu durumlarda başarılı bir cevapla birlikte üretilen datayı ve status code'u döndürmek için kullanılır.
        /// </summary>
        /// <param name="data">Geri döndürülecek veri</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>
            {
                Data = data,
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }
        /// <summary>
        /// Bu metot, işlemin başarılı olduğunu ifade eden bir status code döndürmek için kullanılır.
        /// </summary>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Success(int statusCode)
        {
            return new Response<T>
            {
                Data = default(T),
                StatusCode = statusCode,
                IsSucceeded = true
            };
        }
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak bir hata listesi döndürmek için kullanılır.
        /// </summary>
        /// <param name="errors">Hata listesi</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T>
            {
                Errors = errors,
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }
        /// <summary>
        /// Bu metot, geriye başarısız bir cevap olarak içinde bir hata olan hata listesini döndürmek için kullanılır.
        /// </summary>
        /// <param name="error">Hata metni</param>
        /// <param name="statusCode">İşlemin sonucunu ifade eden kod(200, 201 vb)</param>
        /// <returns>Response<typeparamref name="T"/></returns>
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T>
            {
                Errors = new List<string> { error },
                StatusCode = statusCode,
                IsSucceeded = false
            };
        }

    }
}
