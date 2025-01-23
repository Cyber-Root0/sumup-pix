/*
 * Copyright (c) 2025 Bruno Venancio Alves
 *
 * Author: Bruno Venancio Alves
 * Email: boteistem@gmail.com
 *
 * Permission is granted to use, modify, and distribute this software with
 * acknowledgment of the original author. This notice must not be removed
 * or altered from any source distribution.
 */
namespace SumUp.SDK.Client.Checkout
{
    public class Artefact
    {
        public string name { get; set; }
        public string content_type { get; set; }
        public string location { get; set; }
        public DateTime created_at { get; set; }
        public string content { get; set; }
    }

    public class QrCodePix
    {
        public List<Artefact> artefacts { get; set; }
    }
    public class PixArtefact
    {
        public QrCodePix qr_code_pix { get; set; }
    }


}