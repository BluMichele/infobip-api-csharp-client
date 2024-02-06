/*
 * Infobip Client API Libraries OpenAPI Specification
 * OpenAPI specification containing public endpoints supported in client API libraries.
 *
 * Contact: support@infobip.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * Do not edit the class manually.
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;

namespace Infobip.Api.Client.Model
{
    /// <summary>
    ///     SmsTextualMessage
    /// </summary>
    [DataContract(Name = "SmsTextualMessage")]
    public class SmsTextualMessage : IEquatable<SmsTextualMessage>
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SmsTextualMessage" /> class.
        /// </summary>
        /// <param name="callbackData">
        ///     Additional client&#39;s data that will be sent on the notifyUrl. The maximum value is 200
        ///     characters..
        /// </param>
        /// <param name="deliveryTimeWindow">
        ///     Scheduling object that allows setting up detailed time windows in which the message
        ///     can be sent. Consists of &#x60;from&#x60;, &#x60;to&#x60; and &#x60;days&#x60; properties. &#x60;Days&#x60;
        ///     property is mandatory. &#x60;From&#x60; and &#x60;to&#x60; properties should be either both included, to allow
        ///     finer time window granulation or both omitted, to include whole days in the delivery time window..
        /// </param>
        /// <param name="destinations">destinations.</param>
        /// <param name="flash">
        ///     Can be &#x60;true&#x60; or &#x60;false&#x60;. If the value is set to &#x60;true&#x60;, a flash SMS
        ///     will be sent. Otherwise, a normal SMS will be sent. The default value is &#x60;false&#x60;..
        /// </param>
        /// <param name="from">
        ///     Represents a sender ID which can be alphanumeric or numeric. Alphanumeric sender ID length should be
        ///     between 3 and 11 characters (Example: &#x60;CompanyName&#x60;). Numeric sender ID length should be between 3 and 14
        ///     characters..
        /// </param>
        /// <param name="intermediateReport">
        ///     The real-time Intermediate delivery report that will be sent on your callback server.
        ///     Can be &#x60;true&#x60; or &#x60;false&#x60;..
        /// </param>
        /// <param name="language">language.</param>
        /// <param name="notifyContentType">
        ///     Preferred Delivery report content type. Can be &#x60;application/json&#x60; or &#x60;
        ///     application/xml&#x60;..
        /// </param>
        /// <param name="notifyUrl">The URL on your call back server on which the Delivery report will be sent..</param>
        /// <param name="regional">
        ///     Region specific parameters, often specified by local laws. Use this if country or region that
        ///     you are sending SMS to requires some extra parameters..
        /// </param>
        /// <param name="sendAt">
        ///     Date and time when the message is to be sent. Used for scheduled SMS (SMS not sent immediately,
        ///     but at the scheduled time). Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;..
        /// </param>
        /// <param name="text">Text of the message that will be sent..</param>
        /// <param name="transliteration">
        ///     Conversion of a message text from one script to another. Possible values: &#x60;TURKISH
        ///     &#x60;, &#x60;GREEK&#x60;, &#x60;CYRILLIC&#x60;, &#x60;SERBIAN_CYRILLIC&#x60;, &#x60;CENTRAL_EUROPEAN&#x60;, &#x60;
        ///     BALTIC&#x60; and &#x60;NON_UNICODE&#x60;..
        /// </param>
        /// <param name="validityPeriod">
        ///     The message validity period in minutes. When the period expires, it will not be allowed
        ///     for the message to be sent. Validity period longer than 48h is not supported (in this case, it will be
        ///     automatically set to 48h)..
        /// </param>
        public SmsTextualMessage(string callbackData = default(string),
            SmsDeliveryTimeWindow deliveryTimeWindow = default,
            List<SmsDestination> destinations = default(List<SmsDestination>), bool flash = default(bool),
            string from = default(string), bool intermediateReport = default(bool), SmsLanguage language = default,
            string notifyContentType = default(string), string notifyUrl = default(string),
            SmsRegionalOptions regional = default, DateTimeOffset sendAt = default(DateTimeOffset),
            string text = default(string), string transliteration = default(string),
            long validityPeriod = default(long))
        {
            CallbackData = callbackData;
            DeliveryTimeWindow = deliveryTimeWindow;
            Destinations = destinations;
            Flash = flash;
            From = from;
            IntermediateReport = intermediateReport;
            Language = language;
            NotifyContentType = notifyContentType;
            NotifyUrl = notifyUrl;
            Regional = regional;
            SendAt = sendAt;
            Text = text;
            Transliteration = transliteration;
            ValidityPeriod = validityPeriod;
        }

        /// <summary>
        ///     Additional client&#39;s data that will be sent on the notifyUrl. The maximum value is 200 characters.
        /// </summary>
        /// <value>Additional client&#39;s data that will be sent on the notifyUrl. The maximum value is 200 characters.</value>
        [DataMember(Name = "callbackData", EmitDefaultValue = false)]
        public string CallbackData { get; set; }

        /// <summary>
        ///     Scheduling object that allows setting up detailed time windows in which the message can be sent. Consists of &#x60;
        ///     from&#x60;, &#x60;to&#x60; and &#x60;days&#x60; properties. &#x60;Days&#x60; property is mandatory. &#x60;From
        ///     &#x60; and &#x60;to&#x60; properties should be either both included, to allow finer time window granulation or both
        ///     omitted, to include whole days in the delivery time window.
        /// </summary>
        /// <value>
        ///     Scheduling object that allows setting up detailed time windows in which the message can be sent. Consists of
        ///     &#x60;from&#x60;, &#x60;to&#x60; and &#x60;days&#x60; properties. &#x60;Days&#x60; property is mandatory. &#x60;
        ///     From&#x60; and &#x60;to&#x60; properties should be either both included, to allow finer time window granulation or
        ///     both omitted, to include whole days in the delivery time window.
        /// </value>
        [DataMember(Name = "deliveryTimeWindow", EmitDefaultValue = false)]
        public SmsDeliveryTimeWindow DeliveryTimeWindow { get; set; }

        /// <summary>
        ///     Gets or Sets Destinations
        /// </summary>
        [DataMember(Name = "destinations", EmitDefaultValue = false)]
        public List<SmsDestination> Destinations { get; set; }

        /// <summary>
        ///     Can be &#x60;true&#x60; or &#x60;false&#x60;. If the value is set to &#x60;true&#x60;, a flash SMS will be sent.
        ///     Otherwise, a normal SMS will be sent. The default value is &#x60;false&#x60;.
        /// </summary>
        /// <value>
        ///     Can be &#x60;true&#x60; or &#x60;false&#x60;. If the value is set to &#x60;true&#x60;, a flash SMS will be sent.
        ///     Otherwise, a normal SMS will be sent. The default value is &#x60;false&#x60;.
        /// </value>
        [DataMember(Name = "flash", EmitDefaultValue = true)]
        public bool Flash { get; set; }

        /// <summary>
        ///     Represents a sender ID which can be alphanumeric or numeric. Alphanumeric sender ID length should be between 3 and
        ///     11 characters (Example: &#x60;CompanyName&#x60;). Numeric sender ID length should be between 3 and 14 characters.
        /// </summary>
        /// <value>
        ///     Represents a sender ID which can be alphanumeric or numeric. Alphanumeric sender ID length should be between 3
        ///     and 11 characters (Example: &#x60;CompanyName&#x60;). Numeric sender ID length should be between 3 and 14
        ///     characters.
        /// </value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        ///     Required for entity use in a send request for outbound traffic. Returned in notification events.
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public string EntityId { get; set; }

        /// <summary>
        ///     Required for application use in a send request for outbound traffic. Returned in notification events. 
        /// </summary>
        [DataMember(Name = "applicationId", EmitDefaultValue = false)]
        public string ApplicationId { get; set; }

        /// <summary>
        ///     The real-time Intermediate delivery report that will be sent on your callback server. Can be &#x60;true&#x60; or
        ///     &#x60;false&#x60;.
        /// </summary>
        /// <value>
        ///     The real-time Intermediate delivery report that will be sent on your callback server. Can be &#x60;true&#x60; or
        ///     &#x60;false&#x60;.
        /// </value>
        [DataMember(Name = "intermediateReport", EmitDefaultValue = true)]
        public bool IntermediateReport { get; set; }

        /// <summary>
        ///     Gets or Sets Language
        /// </summary>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public SmsLanguage Language { get; set; }

        /// <summary>
        ///     Preferred Delivery report content type. Can be &#x60;application/json&#x60; or &#x60;application/xml&#x60;.
        /// </summary>
        /// <value>Preferred Delivery report content type. Can be &#x60;application/json&#x60; or &#x60;application/xml&#x60;.</value>
        [DataMember(Name = "notifyContentType", EmitDefaultValue = false)]
        public string NotifyContentType { get; set; }

        /// <summary>
        ///     The URL on your call back server on which the Delivery report will be sent.
        /// </summary>
        /// <value>The URL on your call back server on which the Delivery report will be sent.</value>
        [DataMember(Name = "notifyUrl", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        ///     Region specific parameters, often specified by local laws. Use this if country or region that you are sending SMS
        ///     to requires some extra parameters.
        /// </summary>
        /// <value>
        ///     Region specific parameters, often specified by local laws. Use this if country or region that you are sending
        ///     SMS to requires some extra parameters.
        /// </value>
        [DataMember(Name = "regional", EmitDefaultValue = false)]
        public SmsRegionalOptions Regional { get; set; }

        /// <summary>
        ///     Date and time when the message is to be sent. Used for scheduled SMS (SMS not sent immediately, but at the
        ///     scheduled time). Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </summary>
        /// <value>
        ///     Date and time when the message is to be sent. Used for scheduled SMS (SMS not sent immediately, but at the
        ///     scheduled time). Has the following format: &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSZ&#x60;.
        /// </value>
        [DataMember(Name = "sendAt", EmitDefaultValue = false)]
        public DateTimeOffset SendAt { get; set; }

        /// <summary>
        ///     Text of the message that will be sent.
        /// </summary>
        /// <value>Text of the message that will be sent.</value>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        ///     Conversion of a message text from one script to another. Possible values: &#x60;TURKISH&#x60;, &#x60;GREEK&#x60;,
        ///     &#x60;CYRILLIC&#x60;, &#x60;SERBIAN_CYRILLIC&#x60;, &#x60;CENTRAL_EUROPEAN&#x60;, &#x60;BALTIC&#x60; and &#x60;
        ///     NON_UNICODE&#x60;.
        /// </summary>
        /// <value>
        ///     Conversion of a message text from one script to another. Possible values: &#x60;TURKISH&#x60;, &#x60;GREEK&#x60;
        ///     , &#x60;CYRILLIC&#x60;, &#x60;SERBIAN_CYRILLIC&#x60;, &#x60;CENTRAL_EUROPEAN&#x60;, &#x60;BALTIC&#x60; and &#x60;
        ///     NON_UNICODE&#x60;.
        /// </value>
        [DataMember(Name = "transliteration", EmitDefaultValue = false)]
        public string Transliteration { get; set; }

        /// <summary>
        ///     The message validity period in minutes. When the period expires, it will not be allowed for the message to be sent.
        ///     Validity period longer than 48h is not supported (in this case, it will be automatically set to 48h).
        /// </summary>
        /// <value>
        ///     The message validity period in minutes. When the period expires, it will not be allowed for the message to be
        ///     sent. Validity period longer than 48h is not supported (in this case, it will be automatically set to 48h).
        /// </value>
        [DataMember(Name = "validityPeriod", EmitDefaultValue = false)]
        public long ValidityPeriod { get; set; }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsTextualMessage {\n");
            sb.Append("  CallbackData: ").Append(CallbackData).Append("\n");
            sb.Append("  DeliveryTimeWindow: ").Append(DeliveryTimeWindow).Append("\n");
            sb.Append("  Destinations: ").Append(Destinations).Append("\n");
            sb.Append("  Flash: ").Append(Flash).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  IntermediateReport: ").Append(IntermediateReport).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  NotifyContentType: ").Append(NotifyContentType).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  Regional: ").Append(Regional).Append("\n");
            sb.Append("  SendAt: ").Append(SendAt).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Transliteration: ").Append(Transliteration).Append("\n");
            sb.Append("  ValidityPeriod: ").Append(ValidityPeriod).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SmsTextualMessage);
        }

        /// <summary>
        ///     Returns true if SmsTextualMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsTextualMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsTextualMessage input)
        {
            if (input == null)
                return false;

            return
                (
                    CallbackData == input.CallbackData ||
                    CallbackData != null &&
                    CallbackData.Equals(input.CallbackData)
                ) &&
                (
                    DeliveryTimeWindow == input.DeliveryTimeWindow ||
                    DeliveryTimeWindow != null &&
                    DeliveryTimeWindow.Equals(input.DeliveryTimeWindow)
                ) &&
                (
                    Destinations == input.Destinations ||
                    Destinations != null &&
                    input.Destinations != null &&
                    Destinations.SequenceEqual(input.Destinations)
                ) &&
                (
                    Flash == input.Flash ||
                    Flash.Equals(input.Flash)
                ) &&
                (
                    From == input.From ||
                    From != null &&
                    From.Equals(input.From)
                ) &&
                (
                    IntermediateReport == input.IntermediateReport ||
                    IntermediateReport.Equals(input.IntermediateReport)
                ) &&
                (
                    Language == input.Language ||
                    Language != null &&
                    Language.Equals(input.Language)
                ) &&
                (
                    NotifyContentType == input.NotifyContentType ||
                    NotifyContentType != null &&
                    NotifyContentType.Equals(input.NotifyContentType)
                ) &&
                (
                    NotifyUrl == input.NotifyUrl ||
                    NotifyUrl != null &&
                    NotifyUrl.Equals(input.NotifyUrl)
                ) &&
                (
                    Regional == input.Regional ||
                    Regional != null &&
                    Regional.Equals(input.Regional)
                ) &&
                (
                    SendAt == input.SendAt ||
                    SendAt != null &&
                    SendAt.Equals(input.SendAt)
                ) &&
                (
                    Text == input.Text ||
                    Text != null &&
                    Text.Equals(input.Text)
                ) &&
                (
                    Transliteration == input.Transliteration ||
                    Transliteration != null &&
                    Transliteration.Equals(input.Transliteration)
                ) &&
                (
                    ValidityPeriod == input.ValidityPeriod ||
                    ValidityPeriod.Equals(input.ValidityPeriod)
                );
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (CallbackData != null)
                    hashCode = hashCode * 59 + CallbackData.GetHashCode();
                if (DeliveryTimeWindow != null)
                    hashCode = hashCode * 59 + DeliveryTimeWindow.GetHashCode();
                if (Destinations != null)
                    hashCode = hashCode * 59 + Destinations.GetHashCode();
                hashCode = hashCode * 59 + Flash.GetHashCode();
                if (From != null)
                    hashCode = hashCode * 59 + From.GetHashCode();
                hashCode = hashCode * 59 + IntermediateReport.GetHashCode();
                if (Language != null)
                    hashCode = hashCode * 59 + Language.GetHashCode();
                if (NotifyContentType != null)
                    hashCode = hashCode * 59 + NotifyContentType.GetHashCode();
                if (NotifyUrl != null)
                    hashCode = hashCode * 59 + NotifyUrl.GetHashCode();
                if (Regional != null)
                    hashCode = hashCode * 59 + Regional.GetHashCode();
                if (SendAt != null)
                    hashCode = hashCode * 59 + SendAt.GetHashCode();
                if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                if (Transliteration != null)
                    hashCode = hashCode * 59 + Transliteration.GetHashCode();
                hashCode = hashCode * 59 + ValidityPeriod.GetHashCode();
                return hashCode;
            }
        }
    }
}