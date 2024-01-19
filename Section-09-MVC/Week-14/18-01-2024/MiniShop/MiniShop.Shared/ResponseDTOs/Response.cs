using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShop.Shared.ResponseDTOs
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }
        public bool IsSucceeded { get; set; }
        /// <summary>
        /// Bu metot, yapilan islemin basarili oldugu durumlarda basarili bir cevapla birlikte uretilen datayi ve status codu'u dondurmek icin kullanilir.
        /// </summary>
        /// <param name="data">Geri dondurulecek veri</param>
        /// <param name="statusCode">islemin sonucunu ifade eden kod(200, 201vb.)</param>
        /// <returns>Response <typeparamref name="T"/></returns>
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
        /// Bu metot, islemin basarili oldugunu ifade eden bir status code dondurmek icin kullanilir.
        /// </summary>
        /// <param name="statusCode">islemin sonucunu ifade eden kod(200, 201 vb.)</param>
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
        /// Bu metot geriye basarisiz bir cevap olarak icinde olan hata listesini dondurmek icin kullanilir
        /// </summary>
        /// <param name="errors">hata listesi</param>
        /// <param name="statusCode">islemin sonucunu ifade eden kod(200, 201 vb.)</param>
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
        /// Bu metot geriye basarisiz bir cevap olarak icinde BIR hata olan hata listesini dondurmek icin kullanilir
        /// </summary>
        /// <param name="error">hata metni</param>
        /// <param name="statusCode">islemin sonucunu ifade eden kod(200, 201 vb.)</param>
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