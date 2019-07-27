﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kerberos.NET {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Kerberos.NET.Strings", typeof(Strings).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Only single dimensional arrays are supported for the requested action..
        /// </summary>
        internal static string Arg_RankMultiDimNotSupported {
            get {
                return ResourceManager.GetString("Arg_RankMultiDimNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The destination is too small to hold the encoded value..
        /// </summary>
        internal static string Argument_EncodeDestinationTooSmall {
            get {
                return ResourceManager.GetString("Argument_EncodeDestinationTooSmall", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Offset and length were out of bounds for the array or count is greater than the number of elements from index to the end of the source collection..
        /// </summary>
        internal static string Argument_InvalidOffLen {
            get {
                return ResourceManager.GetString("Argument_InvalidOffLen", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OID value was invalid..
        /// </summary>
        internal static string Argument_InvalidOidValue {
            get {
                return ResourceManager.GetString("Argument_InvalidOidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value was invalid..
        /// </summary>
        internal static string Argument_InvalidValue {
            get {
                return ResourceManager.GetString("Argument_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Index was out of range. Must be non-negative and less than the size of the collection..
        /// </summary>
        internal static string ArgumentOutOfRange_Index {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_Index", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Non-negative number required..
        /// </summary>
        internal static string ArgumentOutOfRange_NeedNonNegNum {
            get {
                return ResourceManager.GetString("ArgumentOutOfRange_NeedNonNegNum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN.1 Enumerated values only apply to enum types without the [Flags] attribute..
        /// </summary>
        internal static string Cryptography_Asn_EnumeratedValueRequiresNonFlagsEnum {
            get {
                return ResourceManager.GetString("Cryptography_Asn_EnumeratedValueRequiresNonFlagsEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Named bit list operations require an enum with the [Flags] attribute..
        /// </summary>
        internal static string Cryptography_Asn_NamedBitListRequiresFlagsEnum {
            get {
                return ResourceManager.GetString("Cryptography_Asn_NamedBitListRequiresFlagsEnum", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The encoded named bit list value is larger than the value size of the &apos;{0}&apos; enum..
        /// </summary>
        internal static string Cryptography_Asn_NamedBitListValueTooBig {
            get {
                return ResourceManager.GetString("Cryptography_Asn_NamedBitListValueTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Tags with TagClass Universal must have the appropriate TagValue value for the data type being read or written..
        /// </summary>
        internal static string Cryptography_Asn_UniversalValueIsFixed {
            get {
                return ResourceManager.GetString("Cryptography_Asn_UniversalValueIsFixed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unused bit count must be between 0 and 7, inclusive..
        /// </summary>
        internal static string Cryptography_Asn_UnusedBitCountRange {
            get {
                return ResourceManager.GetString("Cryptography_Asn_UnusedBitCountRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Encode cannot be called while a Sequence or SetOf is still open..
        /// </summary>
        internal static string Cryptography_AsnWriter_EncodeUnbalancedStack {
            get {
                return ResourceManager.GetString("Cryptography_AsnWriter_EncodeUnbalancedStack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot pop the requested tag as it is not currently in progress..
        /// </summary>
        internal static string Cryptography_AsnWriter_PopWrongTag {
            get {
                return ResourceManager.GetString("Cryptography_AsnWriter_PopWrongTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN1 corrupted data..
        /// </summary>
        internal static string Cryptography_Der_Invalid_Encoding {
            get {
                return ResourceManager.GetString("Cryptography_Der_Invalid_Encoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ASN1 corrupted data. Expected {0}; Actual: {1}.
        /// </summary>
        internal static string Cryptography_Der_Invalid_Encoding_Expected_Encoding {
            get {
                return ResourceManager.GetString("Cryptography_Der_Invalid_Encoding_Expected_Encoding", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string contains a character not in the 7 bit ASCII character set..
        /// </summary>
        internal static string Cryptography_Invalid_IA5String {
            get {
                return ResourceManager.GetString("Cryptography_Invalid_IA5String", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No OID value matches this name..
        /// </summary>
        internal static string Cryptography_Oid_InvalidName {
            get {
                return ResourceManager.GetString("Cryptography_Oid_InvalidName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The OID value is invalid..
        /// </summary>
        internal static string Cryptography_Oid_InvalidValue {
            get {
                return ResourceManager.GetString("Cryptography_Oid_InvalidValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NoLength of the data to encrypt is invalid..
        /// </summary>
        internal static string Cryptography_SSE_InvalidDataSize {
            get {
                return ResourceManager.GetString("Cryptography_SSE_InvalidDataSize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The input to WriteEncodedValue must represent a single encoded value with no trailing data..
        /// </summary>
        internal static string Cryptography_WriteEncodedValue_OneValueAtATime {
            get {
                return ResourceManager.GetString("Cryptography_WriteEncodedValue_OneValueAtATime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested protocol version number not supported.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_BAD_PVNO {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_BAD_PVNO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC cannot accommodate requested option.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_BADOPTION {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_BADOPTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client&apos;s key encrypted in old master key.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_C_OLD_MAST_KVNO {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_C_OLD_MAST_KVNO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client not found in Kerberos database.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_C_PRINCIPAL_UNKNOWN {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_C_PRINCIPAL_UNKNOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ticket not eligible for postdating.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CANNOT_POSTDATE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CANNOT_POSTDATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CANT_VERIFY_CERTIFICATE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CANT_VERIFY_CERTIFICATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CERTIFICATE_MISMATCH {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CERTIFICATE_MISMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CLIENT_NAME_MISMATCH {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CLIENT_NAME_MISMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client not yet valid; try again later.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CLIENT_NOTYET {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CLIENT_NOTYET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clients credentials have been revoked.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_CLIENT_REVOKED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_CLIENT_REVOKED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC has no support for encryption type.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_ETYPE_NOSUPP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_ETYPE_NOSUPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_INVALID_CERTIFICATE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_INVALID_CERTIFICATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_KDC_NAME_MISMATCH {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_KDC_NAME_MISMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password has expired; change password to reset.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_KEY_EXPIRED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_KEY_EXPIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_KEY_TOO_WEAK {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_KEY_TOO_WEAK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server principal valid for user2user only.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_MUST_USE_USER2USER {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_MUST_USE_USER2USER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Client&apos;s entry in database has expired.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_NAME_EXP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_NAME_EXP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested starttime is later than end time.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_NEVER_VALID {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_NEVER_VALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The client or server has a null key.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_NULL_KEY {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_NULL_KEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC has no support for padata type.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_PADATA_TYPE_NOSUPP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_PADATA_TYPE_NOSUPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC Policy rejects transited path.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_PATH_NOT_ACCEPTED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_PATH_NOT_ACCEPTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC policy rejects request.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_POLICY {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_POLICY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pre-authentication information was invalid.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_PREAUTH_FAILED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_PREAUTH_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Additional pre- authentication required.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_PREAUTH_REQUIRED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_PREAUTH_REQUIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple principal entries in database.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_PRINCIPAL_NOT_UNIQUE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_PRINCIPAL_NOT_UNIQUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_REVOCATION_STATUS_UNAVAILABLE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_REVOCATION_STATUS_UNAVAILABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_REVOCATION_STATUS_UNKNOWN {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_REVOCATION_STATUS_UNKNOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_REVOKED_CERTIFICATE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_REVOKED_CERTIFICATE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server&apos;s key encrypted in old master key.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_S_OLD_MAST_KVNO {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_S_OLD_MAST_KVNO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server not found in Kerberos database.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_S_PRINCIPAL_UNKNOWN {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_S_PRINCIPAL_UNKNOWN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Requested server and ticket don&apos;t match.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SERVER_NOMATCH {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SERVER_NOMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server&apos;s entry in database has expired.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SERVICE_EXP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SERVICE_EXP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server not yet valid; try again later.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SERVICE_NOTYET {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SERVICE_NOTYET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Credentials for server have been revoked.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SERVICE_REVOKED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SERVICE_REVOKED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC has no support for checksum type.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SUMTYPE_NOSUPP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SUMTYPE_NOSUPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A service is not available.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_SVC_UNAVAILABLE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_SVC_UNAVAILABLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TGT has been revoked.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_TGT_REVOKED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_TGT_REVOKED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to KDC has no support for transited type.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_TRTYPE_NOSUPP {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_TRTYPE_NOSUPP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for future use.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERR_WRONG_REALM {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERR_WRONG_REALM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERROR_CLIENT_NOT_TRUSTED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERROR_CLIENT_NOT_TRUSTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERROR_INVALID_SIG {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERROR_INVALID_SIG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Reserved for PKINIT.
        /// </summary>
        internal static string KRB_ERROR_KDC_ERROR_KDC_NOT_TRUSTED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KDC_ERROR_KDC_NOT_TRUSTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Integrity check on decrypted field failed.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BAD_INTEGRITY {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BAD_INTEGRITY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect net address.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADADDR {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADADDR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect message direction.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADDIRECTION {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADDIRECTION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specified version of key is not available.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADKEYVER {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADKEYVER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ticket and authenticator don&apos;t match.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADMATCH {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADMATCH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message out of order.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADORDER {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADORDER", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect sequence number in message.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADSEQ {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADSEQ", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Protocol version mismatch.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_BADVERSION {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_BADVERSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inappropriate type of checksum in message.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_INAPP_CKSUM {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_INAPP_CKSUM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alternative authentication method required.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_METHOD {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_METHOD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Message stream modified.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_MODIFIED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_MODIFIED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid msg type.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_MSG_TYPE {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_MSG_TYPE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mutual authentication failed.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_MUT_FAIL {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_MUT_FAIL", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No TGT available to validate USER-TO-USER.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_NO_TGT {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_NO_TGT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Service key not available.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_NOKEY {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_NOKEY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ticket isn&apos;t for us.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_NOT_US {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_NOT_US", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request is a replay.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_REPEAT {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_REPEAT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Clock skew too great.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_SKEW {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_SKEW", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ticket expired.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_TKT_EXPIRED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_TKT_EXPIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ticket not yet valid.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_TKT_NYV {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_TKT_NYV", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ticket must be for USER-TO-USER.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_ERR_USER_TO_USER_REQUIRED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_ERR_USER_TO_USER_REQUIRED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Policy rejects transited path.
        /// </summary>
        internal static string KRB_ERROR_KRB_AP_PATH_NOT_ACCEPTED {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_AP_PATH_NOT_ACCEPTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Field is too long for this implementation.
        /// </summary>
        internal static string KRB_ERROR_KRB_ERR_FIELD_TOOLONG {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_ERR_FIELD_TOOLONG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generic error (description in e-text).
        /// </summary>
        internal static string KRB_ERROR_KRB_ERR_GENERIC {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_ERR_GENERIC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Response too big for UDP; retry with TCP.
        /// </summary>
        internal static string KRB_ERROR_KRB_ERR_RESPONSE_TOO_BIG {
            get {
                return ResourceManager.GetString("KRB_ERROR_KRB_ERR_RESPONSE_TOO_BIG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot access a disposed object..
        /// </summary>
        internal static string ObjectDisposed_Generic {
            get {
                return ResourceManager.GetString("ObjectDisposed_Generic", resourceCulture);
            }
        }
    }
}