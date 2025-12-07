using System;
using System.Text.Json.Serialization;

namespace Deploy.Schema.Org
{
    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
    public partial class Drug : Substance
    {
        public Drug()
        {
            Type = "Drug";
        }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("activeIngredient")]
        public virtual string? ActiveIngredient { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("administrationRoute")]
        public virtual string? AdministrationRoute { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("alcoholWarning")]
        public virtual string? AlcoholWarning { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("availableStrength")]
        public virtual DrugStrength? AvailableStrength { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("breastfeedingWarning")]
        public virtual string? BreastfeedingWarning { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("clincalPharmacology")]
        public virtual string? ClincalPharmacology { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("clinicalPharmacology")]
        public virtual string? ClinicalPharmacology { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("dosageForm")]
        public virtual string? DosageForm { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("doseSchedule")]
        public virtual DoseSchedule? DoseSchedule { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("drugClass")]
        public virtual DrugClass? DrugClass { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("drugUnit")]
        public virtual string? DrugUnit { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("foodWarning")]
        public virtual string? FoodWarning { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("includedInHealthInsurancePlan")]
        public virtual HealthInsurancePlan? IncludedInHealthInsurancePlan { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("interactingDrug")]
        public virtual Drug? InteractingDrug { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("isAvailableGenerically")]
        public virtual bool? IsAvailableGenerically { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("isProprietary")]
        public virtual bool? IsProprietary { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("labelDetails")]
        public virtual string? LabelDetails { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("legalStatus")]
        public virtual object? LegalStatus { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("maximumIntake")]
        public virtual MaximumDoseSchedule? MaximumIntake { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("mechanismOfAction")]
        public virtual string? MechanismOfAction { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("nonProprietaryName")]
        public virtual string? NonProprietaryName { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("overdosage")]
        public virtual string? Overdosage { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("pregnancyCategory")]
        public virtual DrugPregnancyCategory? PregnancyCategory { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("pregnancyWarning")]
        public virtual string? PregnancyWarning { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("prescribingInfo")]
        public virtual string? PrescribingInfo { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("prescriptionStatus")]
        public virtual object? PrescriptionStatus { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("proprietaryName")]
        public virtual string? ProprietaryName { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("relatedDrug")]
        public virtual Drug? RelatedDrug { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("rxcui")]
        public virtual string? Rxcui { get; set; }

    /// <summary>
    /// A chemical or biologic substance, used as a medical therapy, that has a physiological effect on an organism. Here the term drug is used interchangeably with the term medicine although clinical knowledge makes a clear difference between them.
    /// </summary>
        [JsonPropertyName("warning")]
        public virtual object? Warning { get; set; }

    }
}
