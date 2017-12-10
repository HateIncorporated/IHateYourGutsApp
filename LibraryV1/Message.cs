using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibraryV1
{
    public class Message
    {
        public int MessageId { get; set; }

        public string MessageText { get; set; }
        

        [ForeignKey("SenderAccount")]
        public int SenderAccountId { get; set; }
        [ForeignKey("RecieverAccount")]
        public int RecieverAccountId { get; set; }
        
        [InverseProperty("MessageSenderAccounts")]
        public Account SenderAccount { get; set; }
        [InverseProperty("MessageRecieverAccounts")]
        public Account RecieverAccount { get; set; }
        
    }
    //public class SellerDebtor
    //{
    //    public int SellerDebtorId { get; set; }
    //    [ForeignKey("DebtorCompany")]
    //    public int DebtorCompanyId { get; set; }
    //    [ForeignKey("SellerCompany")]
    //    public int SellerCompanyId { get; set; }

    //    [InverseProperty("SellerDebtorDebtorCompanies")]
    //    public Company DebtorCompany { get; set; }
    //    [InverseProperty("SellerDebtorSellerCompanies")]
    //    public Company SellerCompany { get; set; }

    //    public ICollection<SellerDebtorInfo> SellerDebtorInfos { get; set; }
    //    public ICollection<SellerDebtorFile> SellerDebtorFiles { get; set; }
    //}
}
