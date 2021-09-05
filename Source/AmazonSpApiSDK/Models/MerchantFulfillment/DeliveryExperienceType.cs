/* 
 * Selling Partner API for Merchant Fulfillment
 *
 * The Selling Partner API for Merchant Fulfillment helps you build applications that let sellers purchase shipping for non-Prime and Prime orders using Amazon’s Buy Shipping Services.
 *
 * OpenAPI spec version: v0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace AmazonSpApiSDK.Models.MerchantFulfillment
{
    /// <summary>
    /// The delivery confirmation level.
    /// </summary>
    /// <value>The delivery confirmation level.</value>

    public enum DeliveryExperienceType
    {

        /// <summary>
        /// Enum DeliveryConfirmationWithAdultSignature for value: DeliveryConfirmationWithAdultSignature
        /// </summary>

        DeliveryConfirmationWithAdultSignature,

        /// <summary>
        /// Enum DeliveryConfirmationWithSignature for value: DeliveryConfirmationWithSignature
        /// </summary>

        DeliveryConfirmationWithSignature,

        /// <summary>
        /// Enum DeliveryConfirmationWithoutSignature for value: DeliveryConfirmationWithoutSignature
        /// </summary>

        DeliveryConfirmationWithoutSignature,

        /// <summary>
        /// Enum NoTracking for value: NoTracking
        /// </summary>

        NoTracking
    }

}