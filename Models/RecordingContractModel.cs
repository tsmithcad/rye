namespace RhymeEngine.V1.Models;

class RecordingContractModel{
       // The date when the contract is signed. 
        public DateTime ContractDate {get; set; }
    
       // The name of the recording label. 
        public string? LabelName {get; set; }

       // The name of the artist. 
        public string? ArtistName {get; set; }

       // The number of songs the artist agrees to record.
        public int NumberOfSongs {get; set; } = 1;

       // The start date for recording. 
        public DateTime StartDate {get; set; }

       // The date by which the artist must deliver finished recordings. 
        public DateTime DeliveryDate {get; set; }

       // The advance payment amount. 
        public decimal? AdvanceAmount {get; set; }

       // The percentage of royalties the artist will receive. 
        public decimal? RoyaltyPercentage {get; set; }

       // The legal jurisdiction governing the contract. 
        public string? Jurisdiction {get; set; }

       // Placeholder for the label's signature. 
        public string? LabelSignature {get; set; }

       // Placeholder for the artist's signature. 
        public string? ArtistSignature {get; set; }

        public void GenerateContract(){

        }
    }