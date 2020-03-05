using System;

namespace MVC_Vue.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }


    public class MessageModel<T>
    {
        /// <summary>
        /// �����Ƿ�ɹ�
        /// </summary>
        public bool success { get; set; } = false;
        /// <summary>
        /// ������Ϣ
        /// </summary>
        public string msg { get; set; } = "�������쳣";
        /// <summary>
        /// �������ݼ���
        /// </summary>
        public T response { get; set; }

    }
}