// <copyright file="DlnaProfilesDlnaProfile.cs" company="Emby LLC">
// Emby.ApiClient. Autogenerated Code. No license applied. 
// </copyright>
// <autogenerated />
namespace Emby.ApiClient.Model
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.Serialization;

    /// <summary>
    /// DlnaProfilesDlnaProfile.
    /// </summary>
    /// <seealso>Emby.Dlna.Profiles.DlnaProfile</seealso>
    public partial class DlnaProfilesDlnaProfile :  IEquatable<DlnaProfilesDlnaProfile>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DlnaProfilesDlnaProfile" /> class.
        /// </summary>
        public DlnaProfilesDlnaProfile()
        {
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <value>The Type.</value>
        public DlnaProfilesDeviceProfileType Type { get; set; }

        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        /// <value>The Path.</value>
        public string Path { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        /// <value>The UserId.</value>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets AlbumArtPn
        /// </summary>
        /// <value>The AlbumArtPn.</value>
        public string AlbumArtPn { get; set; }

        /// <summary>
        /// Gets or Sets MaxAlbumArtWidth
        /// </summary>
        /// <value>The MaxAlbumArtWidth.</value>
        public int? MaxAlbumArtWidth { get; set; }

        /// <summary>
        /// Gets or Sets MaxAlbumArtHeight
        /// </summary>
        /// <value>The MaxAlbumArtHeight.</value>
        public int? MaxAlbumArtHeight { get; set; }

        /// <summary>
        /// Gets or Sets MaxIconWidth
        /// </summary>
        /// <value>The MaxIconWidth.</value>
        public int? MaxIconWidth { get; set; }

        /// <summary>
        /// Gets or Sets MaxIconHeight
        /// </summary>
        /// <value>The MaxIconHeight.</value>
        public int? MaxIconHeight { get; set; }

        /// <summary>
        /// Gets or Sets FriendlyName
        /// </summary>
        /// <value>The FriendlyName.</value>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or Sets Manufacturer
        /// </summary>
        /// <value>The Manufacturer.</value>
        public string Manufacturer { get; set; }

        /// <summary>
        /// Gets or Sets ManufacturerUrl
        /// </summary>
        /// <value>The ManufacturerUrl.</value>
        public string ManufacturerUrl { get; set; }

        /// <summary>
        /// Gets or Sets ModelName
        /// </summary>
        /// <value>The ModelName.</value>
        public string ModelName { get; set; }

        /// <summary>
        /// Gets or Sets ModelDescription
        /// </summary>
        /// <value>The ModelDescription.</value>
        public string ModelDescription { get; set; }

        /// <summary>
        /// Gets or Sets ModelNumber
        /// </summary>
        /// <value>The ModelNumber.</value>
        public string ModelNumber { get; set; }

        /// <summary>
        /// Gets or Sets ModelUrl
        /// </summary>
        /// <value>The ModelUrl.</value>
        public string ModelUrl { get; set; }

        /// <summary>
        /// Gets or Sets SerialNumber
        /// </summary>
        /// <value>The SerialNumber.</value>
        public string SerialNumber { get; set; }

        /// <summary>
        /// Gets or Sets EnableAlbumArtInDidl
        /// </summary>
        /// <value>The EnableAlbumArtInDidl.</value>
        public bool? EnableAlbumArtInDidl { get; set; }

        /// <summary>
        /// Gets or Sets EnableSingleAlbumArtLimit
        /// </summary>
        /// <value>The EnableSingleAlbumArtLimit.</value>
        public bool? EnableSingleAlbumArtLimit { get; set; }

        /// <summary>
        /// Gets or Sets EnableSingleSubtitleLimit
        /// </summary>
        /// <value>The EnableSingleSubtitleLimit.</value>
        public bool? EnableSingleSubtitleLimit { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolInfo
        /// </summary>
        /// <value>The ProtocolInfo.</value>
        public string ProtocolInfo { get; set; }

        /// <summary>
        /// Gets or Sets TimelineOffsetSeconds
        /// </summary>
        /// <value>The TimelineOffsetSeconds.</value>
        public int? TimelineOffsetSeconds { get; set; }

        /// <summary>
        /// Gets or Sets RequiresPlainVideoItems
        /// </summary>
        /// <value>The RequiresPlainVideoItems.</value>
        public bool? RequiresPlainVideoItems { get; set; }

        /// <summary>
        /// Gets or Sets RequiresPlainFolders
        /// </summary>
        /// <value>The RequiresPlainFolders.</value>
        public bool? RequiresPlainFolders { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreTranscodeByteRangeRequests
        /// </summary>
        /// <value>The IgnoreTranscodeByteRangeRequests.</value>
        public bool? IgnoreTranscodeByteRangeRequests { get; set; }

        /// <summary>
        /// Gets or Sets SupportsSamsungBookmark
        /// </summary>
        /// <value>The SupportsSamsungBookmark.</value>
        public bool? SupportsSamsungBookmark { get; set; }

        /// <summary>
        /// Gets or Sets Identification
        /// </summary>
        /// <value>The Identification.</value>
        public DlnaProfilesDeviceIdentification Identification { get; set; }

        /// <summary>
        /// Gets or Sets ProtocolInfoDetection
        /// </summary>
        /// <value>The ProtocolInfoDetection.</value>
        public DlnaProfilesProtocolInfoDetection ProtocolInfoDetection { get; set; }

        /// <summary>
        /// The name.
        /// </summary>
        /// <value>The Name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <value>The Id.</value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets SupportedMediaTypes
        /// </summary>
        /// <value>The SupportedMediaTypes.</value>
        public string SupportedMediaTypes { get; set; }

        /// <summary>
        /// Gets or Sets MaxStreamingBitrate
        /// </summary>
        /// <value>The MaxStreamingBitrate.</value>
        public long? MaxStreamingBitrate { get; set; }

        /// <summary>
        /// Gets or Sets MusicStreamingTranscodingBitrate
        /// </summary>
        /// <value>The MusicStreamingTranscodingBitrate.</value>
        public int? MusicStreamingTranscodingBitrate { get; set; }

        /// <summary>
        /// Gets or Sets MaxStaticMusicBitrate
        /// </summary>
        /// <value>The MaxStaticMusicBitrate.</value>
        public int? MaxStaticMusicBitrate { get; set; }

        /// <summary>
        /// The direct play profiles.
        /// </summary>
        /// <value>The DirectPlayProfiles.</value>
        public List<DirectPlayProfile> DirectPlayProfiles { get; set; }

        /// <summary>
        /// The transcoding profiles.
        /// </summary>
        /// <value>The TranscodingProfiles.</value>
        public List<TranscodingProfile> TranscodingProfiles { get; set; }

        /// <summary>
        /// Gets or Sets ContainerProfiles
        /// </summary>
        /// <value>The ContainerProfiles.</value>
        public List<ContainerProfile> ContainerProfiles { get; set; }

        /// <summary>
        /// Gets or Sets CodecProfiles
        /// </summary>
        /// <value>The CodecProfiles.</value>
        public List<CodecProfile> CodecProfiles { get; set; }

        /// <summary>
        /// Gets or Sets ResponseProfiles
        /// </summary>
        /// <value>The ResponseProfiles.</value>
        public List<ResponseProfile> ResponseProfiles { get; set; }

        /// <summary>
        /// Gets or Sets SubtitleProfiles
        /// </summary>
        /// <value>The SubtitleProfiles.</value>
        public List<SubtitleProfile> SubtitleProfiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DlnaProfilesDlnaProfile {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AlbumArtPn: ").Append(AlbumArtPn).Append("\n");
            sb.Append("  MaxAlbumArtWidth: ").Append(MaxAlbumArtWidth).Append("\n");
            sb.Append("  MaxAlbumArtHeight: ").Append(MaxAlbumArtHeight).Append("\n");
            sb.Append("  MaxIconWidth: ").Append(MaxIconWidth).Append("\n");
            sb.Append("  MaxIconHeight: ").Append(MaxIconHeight).Append("\n");
            sb.Append("  FriendlyName: ").Append(FriendlyName).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  ManufacturerUrl: ").Append(ManufacturerUrl).Append("\n");
            sb.Append("  ModelName: ").Append(ModelName).Append("\n");
            sb.Append("  ModelDescription: ").Append(ModelDescription).Append("\n");
            sb.Append("  ModelNumber: ").Append(ModelNumber).Append("\n");
            sb.Append("  ModelUrl: ").Append(ModelUrl).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  EnableAlbumArtInDidl: ").Append(EnableAlbumArtInDidl).Append("\n");
            sb.Append("  EnableSingleAlbumArtLimit: ").Append(EnableSingleAlbumArtLimit).Append("\n");
            sb.Append("  EnableSingleSubtitleLimit: ").Append(EnableSingleSubtitleLimit).Append("\n");
            sb.Append("  ProtocolInfo: ").Append(ProtocolInfo).Append("\n");
            sb.Append("  TimelineOffsetSeconds: ").Append(TimelineOffsetSeconds).Append("\n");
            sb.Append("  RequiresPlainVideoItems: ").Append(RequiresPlainVideoItems).Append("\n");
            sb.Append("  RequiresPlainFolders: ").Append(RequiresPlainFolders).Append("\n");
            sb.Append("  IgnoreTranscodeByteRangeRequests: ").Append(IgnoreTranscodeByteRangeRequests).Append("\n");
            sb.Append("  SupportsSamsungBookmark: ").Append(SupportsSamsungBookmark).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  ProtocolInfoDetection: ").Append(ProtocolInfoDetection).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SupportedMediaTypes: ").Append(SupportedMediaTypes).Append("\n");
            sb.Append("  MaxStreamingBitrate: ").Append(MaxStreamingBitrate).Append("\n");
            sb.Append("  MusicStreamingTranscodingBitrate: ").Append(MusicStreamingTranscodingBitrate).Append("\n");
            sb.Append("  MaxStaticMusicBitrate: ").Append(MaxStaticMusicBitrate).Append("\n");
            sb.Append("  DirectPlayProfiles: ").Append(DirectPlayProfiles).Append("\n");
            sb.Append("  TranscodingProfiles: ").Append(TranscodingProfiles).Append("\n");
            sb.Append("  ContainerProfiles: ").Append(ContainerProfiles).Append("\n");
            sb.Append("  CodecProfiles: ").Append(CodecProfiles).Append("\n");
            sb.Append("  ResponseProfiles: ").Append(ResponseProfiles).Append("\n");
            sb.Append("  SubtitleProfiles: ").Append(SubtitleProfiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DlnaProfilesDlnaProfile);
        }

        /// <summary>
        /// Returns true if DlnaProfilesDlnaProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of DlnaProfilesDlnaProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DlnaProfilesDlnaProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.AlbumArtPn == input.AlbumArtPn ||
                    (this.AlbumArtPn != null &&
                    this.AlbumArtPn.Equals(input.AlbumArtPn))
                ) && 
                (
                    this.MaxAlbumArtWidth == input.MaxAlbumArtWidth ||
                    (this.MaxAlbumArtWidth != null &&
                    this.MaxAlbumArtWidth.Equals(input.MaxAlbumArtWidth))
                ) && 
                (
                    this.MaxAlbumArtHeight == input.MaxAlbumArtHeight ||
                    (this.MaxAlbumArtHeight != null &&
                    this.MaxAlbumArtHeight.Equals(input.MaxAlbumArtHeight))
                ) && 
                (
                    this.MaxIconWidth == input.MaxIconWidth ||
                    (this.MaxIconWidth != null &&
                    this.MaxIconWidth.Equals(input.MaxIconWidth))
                ) && 
                (
                    this.MaxIconHeight == input.MaxIconHeight ||
                    (this.MaxIconHeight != null &&
                    this.MaxIconHeight.Equals(input.MaxIconHeight))
                ) && 
                (
                    this.FriendlyName == input.FriendlyName ||
                    (this.FriendlyName != null &&
                    this.FriendlyName.Equals(input.FriendlyName))
                ) && 
                (
                    this.Manufacturer == input.Manufacturer ||
                    (this.Manufacturer != null &&
                    this.Manufacturer.Equals(input.Manufacturer))
                ) && 
                (
                    this.ManufacturerUrl == input.ManufacturerUrl ||
                    (this.ManufacturerUrl != null &&
                    this.ManufacturerUrl.Equals(input.ManufacturerUrl))
                ) && 
                (
                    this.ModelName == input.ModelName ||
                    (this.ModelName != null &&
                    this.ModelName.Equals(input.ModelName))
                ) && 
                (
                    this.ModelDescription == input.ModelDescription ||
                    (this.ModelDescription != null &&
                    this.ModelDescription.Equals(input.ModelDescription))
                ) && 
                (
                    this.ModelNumber == input.ModelNumber ||
                    (this.ModelNumber != null &&
                    this.ModelNumber.Equals(input.ModelNumber))
                ) && 
                (
                    this.ModelUrl == input.ModelUrl ||
                    (this.ModelUrl != null &&
                    this.ModelUrl.Equals(input.ModelUrl))
                ) && 
                (
                    this.SerialNumber == input.SerialNumber ||
                    (this.SerialNumber != null &&
                    this.SerialNumber.Equals(input.SerialNumber))
                ) && 
                (
                    this.EnableAlbumArtInDidl == input.EnableAlbumArtInDidl ||
                    (this.EnableAlbumArtInDidl != null &&
                    this.EnableAlbumArtInDidl.Equals(input.EnableAlbumArtInDidl))
                ) && 
                (
                    this.EnableSingleAlbumArtLimit == input.EnableSingleAlbumArtLimit ||
                    (this.EnableSingleAlbumArtLimit != null &&
                    this.EnableSingleAlbumArtLimit.Equals(input.EnableSingleAlbumArtLimit))
                ) && 
                (
                    this.EnableSingleSubtitleLimit == input.EnableSingleSubtitleLimit ||
                    (this.EnableSingleSubtitleLimit != null &&
                    this.EnableSingleSubtitleLimit.Equals(input.EnableSingleSubtitleLimit))
                ) && 
                (
                    this.ProtocolInfo == input.ProtocolInfo ||
                    (this.ProtocolInfo != null &&
                    this.ProtocolInfo.Equals(input.ProtocolInfo))
                ) && 
                (
                    this.TimelineOffsetSeconds == input.TimelineOffsetSeconds ||
                    (this.TimelineOffsetSeconds != null &&
                    this.TimelineOffsetSeconds.Equals(input.TimelineOffsetSeconds))
                ) && 
                (
                    this.RequiresPlainVideoItems == input.RequiresPlainVideoItems ||
                    (this.RequiresPlainVideoItems != null &&
                    this.RequiresPlainVideoItems.Equals(input.RequiresPlainVideoItems))
                ) && 
                (
                    this.RequiresPlainFolders == input.RequiresPlainFolders ||
                    (this.RequiresPlainFolders != null &&
                    this.RequiresPlainFolders.Equals(input.RequiresPlainFolders))
                ) && 
                (
                    this.IgnoreTranscodeByteRangeRequests == input.IgnoreTranscodeByteRangeRequests ||
                    (this.IgnoreTranscodeByteRangeRequests != null &&
                    this.IgnoreTranscodeByteRangeRequests.Equals(input.IgnoreTranscodeByteRangeRequests))
                ) && 
                (
                    this.SupportsSamsungBookmark == input.SupportsSamsungBookmark ||
                    (this.SupportsSamsungBookmark != null &&
                    this.SupportsSamsungBookmark.Equals(input.SupportsSamsungBookmark))
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.ProtocolInfoDetection == input.ProtocolInfoDetection ||
                    (this.ProtocolInfoDetection != null &&
                    this.ProtocolInfoDetection.Equals(input.ProtocolInfoDetection))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.SupportedMediaTypes == input.SupportedMediaTypes ||
                    (this.SupportedMediaTypes != null &&
                    this.SupportedMediaTypes.Equals(input.SupportedMediaTypes))
                ) && 
                (
                    this.MaxStreamingBitrate == input.MaxStreamingBitrate ||
                    (this.MaxStreamingBitrate != null &&
                    this.MaxStreamingBitrate.Equals(input.MaxStreamingBitrate))
                ) && 
                (
                    this.MusicStreamingTranscodingBitrate == input.MusicStreamingTranscodingBitrate ||
                    (this.MusicStreamingTranscodingBitrate != null &&
                    this.MusicStreamingTranscodingBitrate.Equals(input.MusicStreamingTranscodingBitrate))
                ) && 
                (
                    this.MaxStaticMusicBitrate == input.MaxStaticMusicBitrate ||
                    (this.MaxStaticMusicBitrate != null &&
                    this.MaxStaticMusicBitrate.Equals(input.MaxStaticMusicBitrate))
                ) && 
                (
                    this.DirectPlayProfiles == input.DirectPlayProfiles ||
                    this.DirectPlayProfiles != null &&
                    input.DirectPlayProfiles != null &&
                    this.DirectPlayProfiles.SequenceEqual(input.DirectPlayProfiles)
                ) && 
                (
                    this.TranscodingProfiles == input.TranscodingProfiles ||
                    this.TranscodingProfiles != null &&
                    input.TranscodingProfiles != null &&
                    this.TranscodingProfiles.SequenceEqual(input.TranscodingProfiles)
                ) && 
                (
                    this.ContainerProfiles == input.ContainerProfiles ||
                    this.ContainerProfiles != null &&
                    input.ContainerProfiles != null &&
                    this.ContainerProfiles.SequenceEqual(input.ContainerProfiles)
                ) && 
                (
                    this.CodecProfiles == input.CodecProfiles ||
                    this.CodecProfiles != null &&
                    input.CodecProfiles != null &&
                    this.CodecProfiles.SequenceEqual(input.CodecProfiles)
                ) && 
                (
                    this.ResponseProfiles == input.ResponseProfiles ||
                    this.ResponseProfiles != null &&
                    input.ResponseProfiles != null &&
                    this.ResponseProfiles.SequenceEqual(input.ResponseProfiles)
                ) && 
                (
                    this.SubtitleProfiles == input.SubtitleProfiles ||
                    this.SubtitleProfiles != null &&
                    input.SubtitleProfiles != null &&
                    this.SubtitleProfiles.SequenceEqual(input.SubtitleProfiles)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.AlbumArtPn != null)
                    hashCode = hashCode * 59 + this.AlbumArtPn.GetHashCode();
                if (this.MaxAlbumArtWidth != null)
                    hashCode = hashCode * 59 + this.MaxAlbumArtWidth.GetHashCode();
                if (this.MaxAlbumArtHeight != null)
                    hashCode = hashCode * 59 + this.MaxAlbumArtHeight.GetHashCode();
                if (this.MaxIconWidth != null)
                    hashCode = hashCode * 59 + this.MaxIconWidth.GetHashCode();
                if (this.MaxIconHeight != null)
                    hashCode = hashCode * 59 + this.MaxIconHeight.GetHashCode();
                if (this.FriendlyName != null)
                    hashCode = hashCode * 59 + this.FriendlyName.GetHashCode();
                if (this.Manufacturer != null)
                    hashCode = hashCode * 59 + this.Manufacturer.GetHashCode();
                if (this.ManufacturerUrl != null)
                    hashCode = hashCode * 59 + this.ManufacturerUrl.GetHashCode();
                if (this.ModelName != null)
                    hashCode = hashCode * 59 + this.ModelName.GetHashCode();
                if (this.ModelDescription != null)
                    hashCode = hashCode * 59 + this.ModelDescription.GetHashCode();
                if (this.ModelNumber != null)
                    hashCode = hashCode * 59 + this.ModelNumber.GetHashCode();
                if (this.ModelUrl != null)
                    hashCode = hashCode * 59 + this.ModelUrl.GetHashCode();
                if (this.SerialNumber != null)
                    hashCode = hashCode * 59 + this.SerialNumber.GetHashCode();
                if (this.EnableAlbumArtInDidl != null)
                    hashCode = hashCode * 59 + this.EnableAlbumArtInDidl.GetHashCode();
                if (this.EnableSingleAlbumArtLimit != null)
                    hashCode = hashCode * 59 + this.EnableSingleAlbumArtLimit.GetHashCode();
                if (this.EnableSingleSubtitleLimit != null)
                    hashCode = hashCode * 59 + this.EnableSingleSubtitleLimit.GetHashCode();
                if (this.ProtocolInfo != null)
                    hashCode = hashCode * 59 + this.ProtocolInfo.GetHashCode();
                if (this.TimelineOffsetSeconds != null)
                    hashCode = hashCode * 59 + this.TimelineOffsetSeconds.GetHashCode();
                if (this.RequiresPlainVideoItems != null)
                    hashCode = hashCode * 59 + this.RequiresPlainVideoItems.GetHashCode();
                if (this.RequiresPlainFolders != null)
                    hashCode = hashCode * 59 + this.RequiresPlainFolders.GetHashCode();
                if (this.IgnoreTranscodeByteRangeRequests != null)
                    hashCode = hashCode * 59 + this.IgnoreTranscodeByteRangeRequests.GetHashCode();
                if (this.SupportsSamsungBookmark != null)
                    hashCode = hashCode * 59 + this.SupportsSamsungBookmark.GetHashCode();
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.ProtocolInfoDetection != null)
                    hashCode = hashCode * 59 + this.ProtocolInfoDetection.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SupportedMediaTypes != null)
                    hashCode = hashCode * 59 + this.SupportedMediaTypes.GetHashCode();
                if (this.MaxStreamingBitrate != null)
                    hashCode = hashCode * 59 + this.MaxStreamingBitrate.GetHashCode();
                if (this.MusicStreamingTranscodingBitrate != null)
                    hashCode = hashCode * 59 + this.MusicStreamingTranscodingBitrate.GetHashCode();
                if (this.MaxStaticMusicBitrate != null)
                    hashCode = hashCode * 59 + this.MaxStaticMusicBitrate.GetHashCode();
                if (this.DirectPlayProfiles != null)
                    hashCode = hashCode * 59 + this.DirectPlayProfiles.GetHashCode();
                if (this.TranscodingProfiles != null)
                    hashCode = hashCode * 59 + this.TranscodingProfiles.GetHashCode();
                if (this.ContainerProfiles != null)
                    hashCode = hashCode * 59 + this.ContainerProfiles.GetHashCode();
                if (this.CodecProfiles != null)
                    hashCode = hashCode * 59 + this.CodecProfiles.GetHashCode();
                if (this.ResponseProfiles != null)
                    hashCode = hashCode * 59 + this.ResponseProfiles.GetHashCode();
                if (this.SubtitleProfiles != null)
                    hashCode = hashCode * 59 + this.SubtitleProfiles.GetHashCode();
                return hashCode;
            }
        }
    }
}