﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MC.Website.MoviesReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MovieDto", Namespace="http://schemas.datacontract.org/2004/07/MC.ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class MovieDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MC.Website.MoviesReference.GenreDto GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReleaseCountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ReleaseDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public MC.Website.MoviesReference.GenreDto Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReleaseCountry {
            get {
                return this.ReleaseCountryField;
            }
            set {
                if ((object.ReferenceEquals(this.ReleaseCountryField, value) != true)) {
                    this.ReleaseCountryField = value;
                    this.RaisePropertyChanged("ReleaseCountry");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ReleaseDate {
            get {
                return this.ReleaseDateField;
            }
            set {
                if ((this.ReleaseDateField.Equals(value) != true)) {
                    this.ReleaseDateField = value;
                    this.RaisePropertyChanged("ReleaseDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GenreDto", Namespace="http://schemas.datacontract.org/2004/07/MC.ApplicationServices.DTOs")]
    [System.SerializableAttribute()]
    public partial class GenreDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviesReference.IMovies")]
    public interface IMovies {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/GetMovies", ReplyAction="http://tempuri.org/IMovies/GetMoviesResponse")]
        MC.Website.MoviesReference.MovieDto[] GetMovies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/GetMovies", ReplyAction="http://tempuri.org/IMovies/GetMoviesResponse")]
        System.Threading.Tasks.Task<MC.Website.MoviesReference.MovieDto[]> GetMoviesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/GetMovieByID", ReplyAction="http://tempuri.org/IMovies/GetMovieByIDResponse")]
        MC.Website.MoviesReference.MovieDto GetMovieByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/GetMovieByID", ReplyAction="http://tempuri.org/IMovies/GetMovieByIDResponse")]
        System.Threading.Tasks.Task<MC.Website.MoviesReference.MovieDto> GetMovieByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/PostMovie", ReplyAction="http://tempuri.org/IMovies/PostMovieResponse")]
        string PostMovie(MC.Website.MoviesReference.MovieDto movieDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/PostMovie", ReplyAction="http://tempuri.org/IMovies/PostMovieResponse")]
        System.Threading.Tasks.Task<string> PostMovieAsync(MC.Website.MoviesReference.MovieDto movieDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/PutMovie", ReplyAction="http://tempuri.org/IMovies/PutMovieResponse")]
        string PutMovie(MC.Website.MoviesReference.MovieDto movieDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/PutMovie", ReplyAction="http://tempuri.org/IMovies/PutMovieResponse")]
        System.Threading.Tasks.Task<string> PutMovieAsync(MC.Website.MoviesReference.MovieDto movieDto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/DeleteMovie", ReplyAction="http://tempuri.org/IMovies/DeleteMovieResponse")]
        string DeleteMovie(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/DeleteMovie", ReplyAction="http://tempuri.org/IMovies/DeleteMovieResponse")]
        System.Threading.Tasks.Task<string> DeleteMovieAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/Message", ReplyAction="http://tempuri.org/IMovies/MessageResponse")]
        string Message();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovies/Message", ReplyAction="http://tempuri.org/IMovies/MessageResponse")]
        System.Threading.Tasks.Task<string> MessageAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMoviesChannel : MC.Website.MoviesReference.IMovies, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MoviesClient : System.ServiceModel.ClientBase<MC.Website.MoviesReference.IMovies>, MC.Website.MoviesReference.IMovies {
        
        public MoviesClient() {
        }
        
        public MoviesClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MoviesClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MoviesClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public MC.Website.MoviesReference.MovieDto[] GetMovies() {
            return base.Channel.GetMovies();
        }
        
        public System.Threading.Tasks.Task<MC.Website.MoviesReference.MovieDto[]> GetMoviesAsync() {
            return base.Channel.GetMoviesAsync();
        }
        
        public MC.Website.MoviesReference.MovieDto GetMovieByID(int id) {
            return base.Channel.GetMovieByID(id);
        }
        
        public System.Threading.Tasks.Task<MC.Website.MoviesReference.MovieDto> GetMovieByIDAsync(int id) {
            return base.Channel.GetMovieByIDAsync(id);
        }
        
        public string PostMovie(MC.Website.MoviesReference.MovieDto movieDto) {
            return base.Channel.PostMovie(movieDto);
        }
        
        public System.Threading.Tasks.Task<string> PostMovieAsync(MC.Website.MoviesReference.MovieDto movieDto) {
            return base.Channel.PostMovieAsync(movieDto);
        }
        
        public string PutMovie(MC.Website.MoviesReference.MovieDto movieDto) {
            return base.Channel.PutMovie(movieDto);
        }
        
        public System.Threading.Tasks.Task<string> PutMovieAsync(MC.Website.MoviesReference.MovieDto movieDto) {
            return base.Channel.PutMovieAsync(movieDto);
        }
        
        public string DeleteMovie(int id) {
            return base.Channel.DeleteMovie(id);
        }
        
        public System.Threading.Tasks.Task<string> DeleteMovieAsync(int id) {
            return base.Channel.DeleteMovieAsync(id);
        }
        
        public string Message() {
            return base.Channel.Message();
        }
        
        public System.Threading.Tasks.Task<string> MessageAsync() {
            return base.Channel.MessageAsync();
        }
    }
}
