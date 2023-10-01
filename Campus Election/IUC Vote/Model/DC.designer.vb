﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5466
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<System.Data.Linq.Mapping.DatabaseAttribute(Name:="BD_02")>  _
Partial Public Class DCDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertAdministrateur(instance As Administrateur)
    End Sub
  Partial Private Sub UpdateAdministrateur(instance As Administrateur)
    End Sub
  Partial Private Sub DeleteAdministrateur(instance As Administrateur)
    End Sub
  Partial Private Sub InsertVote(instance As Vote)
    End Sub
  Partial Private Sub UpdateVote(instance As Vote)
    End Sub
  Partial Private Sub DeleteVote(instance As Vote)
    End Sub
  Partial Private Sub InsertCandidature(instance As Candidature)
    End Sub
  Partial Private Sub UpdateCandidature(instance As Candidature)
    End Sub
  Partial Private Sub DeleteCandidature(instance As Candidature)
    End Sub
  Partial Private Sub InsertElection(instance As Election)
    End Sub
  Partial Private Sub UpdateElection(instance As Election)
    End Sub
  Partial Private Sub DeleteElection(instance As Election)
    End Sub
  Partial Private Sub InsertEtudiant(instance As Etudiant)
    End Sub
  Partial Private Sub UpdateEtudiant(instance As Etudiant)
    End Sub
  Partial Private Sub DeleteEtudiant(instance As Etudiant)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("BD_02ConnectionString").ConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property Administrateurs() As System.Data.Linq.Table(Of Administrateur)
		Get
			Return Me.GetTable(Of Administrateur)
		End Get
	End Property
	
	Public ReadOnly Property Votes() As System.Data.Linq.Table(Of Vote)
		Get
			Return Me.GetTable(Of Vote)
		End Get
	End Property
	
	Public ReadOnly Property Candidatures() As System.Data.Linq.Table(Of Candidature)
		Get
			Return Me.GetTable(Of Candidature)
		End Get
	End Property
	
	Public ReadOnly Property Elections() As System.Data.Linq.Table(Of Election)
		Get
			Return Me.GetTable(Of Election)
		End Get
	End Property
	
	Public ReadOnly Property Etudiants() As System.Data.Linq.Table(Of Etudiant)
		Get
			Return Me.GetTable(Of Etudiant)
		End Get
	End Property
End Class

<Table(Name:="dbo.Administrateur")>  _
Partial Public Class Administrateur
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Id As Integer
	
	Private _IdEtud As String
	
	Private _Etudiant As EntityRef(Of Etudiant)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnIdEtudChanging(value As String)
    End Sub
    Partial Private Sub OnIdEtudChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Etudiant = CType(Nothing, EntityRef(Of Etudiant))
		OnCreated
	End Sub
	
	<Column(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Id() As Integer
		Get
			Return Me._Id
		End Get
		Set
			If ((Me._Id = value)  _
						= false) Then
				Me.OnIdChanging(value)
				Me.SendPropertyChanging
				Me._Id = value
				Me.SendPropertyChanged("Id")
				Me.OnIdChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_IdEtud", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property IdEtud() As String
		Get
			Return Me._IdEtud
		End Get
		Set
			If (String.Equals(Me._IdEtud, value) = false) Then
				If Me._Etudiant.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnIdEtudChanging(value)
				Me.SendPropertyChanging
				Me._IdEtud = value
				Me.SendPropertyChanged("IdEtud")
				Me.OnIdEtudChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Etudiant_Administrateur", Storage:="_Etudiant", ThisKey:="IdEtud", IsForeignKey:=true)>  _
	Public Property Etudiant() As Etudiant
		Get
			Return Me._Etudiant.Entity
		End Get
		Set
			Dim previousValue As Etudiant = Me._Etudiant.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Etudiant.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Etudiant.Entity = Nothing
					previousValue.Administrateurs.Remove(Me)
				End If
				Me._Etudiant.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Administrateurs.Add(Me)
					Me._IdEtud = value.Matricule
				Else
					Me._IdEtud = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Etudiant")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.Vote")>  _
Partial Public Class Vote
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Code As Integer
	
	Private _Matricule As String
	
	Private _Code_Candidat As Integer
	
	Private _CodeElection As Integer
	
	Private _Nombre As System.Nullable(Of Integer)
	
	Private _Election As EntityRef(Of Election)
	
	Private _Etudiant As EntityRef(Of Etudiant)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCodeChanging(value As Integer)
    End Sub
    Partial Private Sub OnCodeChanged()
    End Sub
    Partial Private Sub OnMatriculeChanging(value As String)
    End Sub
    Partial Private Sub OnMatriculeChanged()
    End Sub
    Partial Private Sub OnCode_CandidatChanging(value As Integer)
    End Sub
    Partial Private Sub OnCode_CandidatChanged()
    End Sub
    Partial Private Sub OnCodeElectionChanging(value As Integer)
    End Sub
    Partial Private Sub OnCodeElectionChanged()
    End Sub
    Partial Private Sub OnNombreChanging(value As System.Nullable(Of Integer))
    End Sub
    Partial Private Sub OnNombreChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Election = CType(Nothing, EntityRef(Of Election))
		Me._Etudiant = CType(Nothing, EntityRef(Of Etudiant))
		OnCreated
	End Sub
	
	<Column(Storage:="_Code", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Code() As Integer
		Get
			Return Me._Code
		End Get
		Set
			If ((Me._Code = value)  _
						= false) Then
				Me.OnCodeChanging(value)
				Me.SendPropertyChanging
				Me._Code = value
				Me.SendPropertyChanged("Code")
				Me.OnCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Matricule", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Matricule() As String
		Get
			Return Me._Matricule
		End Get
		Set
			If (String.Equals(Me._Matricule, value) = false) Then
				If Me._Etudiant.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnMatriculeChanging(value)
				Me.SendPropertyChanging
				Me._Matricule = value
				Me.SendPropertyChanged("Matricule")
				Me.OnMatriculeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Code_Candidat", DbType:="Int NOT NULL")>  _
	Public Property Code_Candidat() As Integer
		Get
			Return Me._Code_Candidat
		End Get
		Set
			If ((Me._Code_Candidat = value)  _
						= false) Then
				Me.OnCode_CandidatChanging(value)
				Me.SendPropertyChanging
				Me._Code_Candidat = value
				Me.SendPropertyChanged("Code_Candidat")
				Me.OnCode_CandidatChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_CodeElection", DbType:="Int NOT NULL")>  _
	Public Property CodeElection() As Integer
		Get
			Return Me._CodeElection
		End Get
		Set
			If ((Me._CodeElection = value)  _
						= false) Then
				If Me._Election.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnCodeElectionChanging(value)
				Me.SendPropertyChanging
				Me._CodeElection = value
				Me.SendPropertyChanged("CodeElection")
				Me.OnCodeElectionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Nombre", DbType:="Int")>  _
	Public Property Nombre() As System.Nullable(Of Integer)
		Get
			Return Me._Nombre
		End Get
		Set
			If (Me._Nombre.Equals(value) = false) Then
				Me.OnNombreChanging(value)
				Me.SendPropertyChanging
				Me._Nombre = value
				Me.SendPropertyChanged("Nombre")
				Me.OnNombreChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Election_Vote", Storage:="_Election", ThisKey:="CodeElection", IsForeignKey:=true)>  _
	Public Property Election() As Election
		Get
			Return Me._Election.Entity
		End Get
		Set
			Dim previousValue As Election = Me._Election.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Election.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Election.Entity = Nothing
					previousValue.Votes.Remove(Me)
				End If
				Me._Election.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Votes.Add(Me)
					Me._CodeElection = value.Code
				Else
					Me._CodeElection = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Election")
			End If
		End Set
	End Property
	
	<Association(Name:="Etudiant_Vote", Storage:="_Etudiant", ThisKey:="Matricule", IsForeignKey:=true)>  _
	Public Property Etudiant() As Etudiant
		Get
			Return Me._Etudiant.Entity
		End Get
		Set
			Dim previousValue As Etudiant = Me._Etudiant.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Etudiant.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Etudiant.Entity = Nothing
					previousValue.Votes.Remove(Me)
				End If
				Me._Etudiant.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Votes.Add(Me)
					Me._Matricule = value.Matricule
				Else
					Me._Matricule = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Etudiant")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.Candidature")>  _
Partial Public Class Candidature
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Code As Integer
	
	Private _Matricule As String
	
	Private _Code_Election As Integer
	
	Private _PhotoProfil As System.Data.Linq.Binary
	
	Private _Extension As String
	
	Private _Election As EntityRef(Of Election)
	
	Private _Etudiant As EntityRef(Of Etudiant)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCodeChanging(value As Integer)
    End Sub
    Partial Private Sub OnCodeChanged()
    End Sub
    Partial Private Sub OnMatriculeChanging(value As String)
    End Sub
    Partial Private Sub OnMatriculeChanged()
    End Sub
    Partial Private Sub OnCode_ElectionChanging(value As Integer)
    End Sub
    Partial Private Sub OnCode_ElectionChanged()
    End Sub
    Partial Private Sub OnPhotoProfilChanging(value As System.Data.Linq.Binary)
    End Sub
    Partial Private Sub OnPhotoProfilChanged()
    End Sub
    Partial Private Sub OnExtensionChanging(value As String)
    End Sub
    Partial Private Sub OnExtensionChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Election = CType(Nothing, EntityRef(Of Election))
		Me._Etudiant = CType(Nothing, EntityRef(Of Etudiant))
		OnCreated
	End Sub
	
	<Column(Storage:="_Code", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Code() As Integer
		Get
			Return Me._Code
		End Get
		Set
			If ((Me._Code = value)  _
						= false) Then
				Me.OnCodeChanging(value)
				Me.SendPropertyChanging
				Me._Code = value
				Me.SendPropertyChanged("Code")
				Me.OnCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Matricule", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Matricule() As String
		Get
			Return Me._Matricule
		End Get
		Set
			If (String.Equals(Me._Matricule, value) = false) Then
				If Me._Etudiant.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnMatriculeChanging(value)
				Me.SendPropertyChanging
				Me._Matricule = value
				Me.SendPropertyChanged("Matricule")
				Me.OnMatriculeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Code_Election", DbType:="Int NOT NULL")>  _
	Public Property Code_Election() As Integer
		Get
			Return Me._Code_Election
		End Get
		Set
			If ((Me._Code_Election = value)  _
						= false) Then
				If Me._Election.HasLoadedOrAssignedValue Then
					Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException
				End If
				Me.OnCode_ElectionChanging(value)
				Me.SendPropertyChanging
				Me._Code_Election = value
				Me.SendPropertyChanged("Code_Election")
				Me.OnCode_ElectionChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_PhotoProfil", DbType:="VarBinary(MAX)", UpdateCheck:=UpdateCheck.Never)>  _
	Public Property PhotoProfil() As System.Data.Linq.Binary
		Get
			Return Me._PhotoProfil
		End Get
		Set
			If (Object.Equals(Me._PhotoProfil, value) = false) Then
				Me.OnPhotoProfilChanging(value)
				Me.SendPropertyChanging
				Me._PhotoProfil = value
				Me.SendPropertyChanged("PhotoProfil")
				Me.OnPhotoProfilChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Extension", DbType:="VarChar(50)")>  _
	Public Property Extension() As String
		Get
			Return Me._Extension
		End Get
		Set
			If (String.Equals(Me._Extension, value) = false) Then
				Me.OnExtensionChanging(value)
				Me.SendPropertyChanging
				Me._Extension = value
				Me.SendPropertyChanged("Extension")
				Me.OnExtensionChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Election_Candidature", Storage:="_Election", ThisKey:="Code_Election", IsForeignKey:=true)>  _
	Public Property Election() As Election
		Get
			Return Me._Election.Entity
		End Get
		Set
			Dim previousValue As Election = Me._Election.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Election.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Election.Entity = Nothing
					previousValue.Candidatures.Remove(Me)
				End If
				Me._Election.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Candidatures.Add(Me)
					Me._Code_Election = value.Code
				Else
					Me._Code_Election = CType(Nothing, Integer)
				End If
				Me.SendPropertyChanged("Election")
			End If
		End Set
	End Property
	
	<Association(Name:="Etudiant_Candidature", Storage:="_Etudiant", ThisKey:="Matricule", IsForeignKey:=true)>  _
	Public Property Etudiant() As Etudiant
		Get
			Return Me._Etudiant.Entity
		End Get
		Set
			Dim previousValue As Etudiant = Me._Etudiant.Entity
			If ((Object.Equals(previousValue, value) = false)  _
						OrElse (Me._Etudiant.HasLoadedOrAssignedValue = false)) Then
				Me.SendPropertyChanging
				If ((previousValue Is Nothing)  _
							= false) Then
					Me._Etudiant.Entity = Nothing
					previousValue.Candidatures.Remove(Me)
				End If
				Me._Etudiant.Entity = value
				If ((value Is Nothing)  _
							= false) Then
					value.Candidatures.Add(Me)
					Me._Matricule = value.Matricule
				Else
					Me._Matricule = CType(Nothing, String)
				End If
				Me.SendPropertyChanged("Etudiant")
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class

<Table(Name:="dbo.Election")>  _
Partial Public Class Election
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Code As Integer
	
	Private _Type As String
	
	Private _Votes As EntitySet(Of Vote)
	
	Private _Candidatures As EntitySet(Of Candidature)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnCodeChanging(value As Integer)
    End Sub
    Partial Private Sub OnCodeChanged()
    End Sub
    Partial Private Sub OnTypeChanging(value As String)
    End Sub
    Partial Private Sub OnTypeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Votes = New EntitySet(Of Vote)(AddressOf Me.attach_Votes, AddressOf Me.detach_Votes)
		Me._Candidatures = New EntitySet(Of Candidature)(AddressOf Me.attach_Candidatures, AddressOf Me.detach_Candidatures)
		OnCreated
	End Sub
	
	<Column(Storage:="_Code", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property Code() As Integer
		Get
			Return Me._Code
		End Get
		Set
			If ((Me._Code = value)  _
						= false) Then
				Me.OnCodeChanging(value)
				Me.SendPropertyChanging
				Me._Code = value
				Me.SendPropertyChanged("Code")
				Me.OnCodeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Type", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Type() As String
		Get
			Return Me._Type
		End Get
		Set
			If (String.Equals(Me._Type, value) = false) Then
				Me.OnTypeChanging(value)
				Me.SendPropertyChanging
				Me._Type = value
				Me.SendPropertyChanged("Type")
				Me.OnTypeChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Election_Vote", Storage:="_Votes", OtherKey:="CodeElection")>  _
	Public Property Votes() As EntitySet(Of Vote)
		Get
			Return Me._Votes
		End Get
		Set
			Me._Votes.Assign(value)
		End Set
	End Property
	
	<Association(Name:="Election_Candidature", Storage:="_Candidatures", OtherKey:="Code_Election")>  _
	Public Property Candidatures() As EntitySet(Of Candidature)
		Get
			Return Me._Candidatures
		End Get
		Set
			Me._Candidatures.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Votes(ByVal entity As Vote)
		Me.SendPropertyChanging
		entity.Election = Me
	End Sub
	
	Private Sub detach_Votes(ByVal entity As Vote)
		Me.SendPropertyChanging
		entity.Election = Nothing
	End Sub
	
	Private Sub attach_Candidatures(ByVal entity As Candidature)
		Me.SendPropertyChanging
		entity.Election = Me
	End Sub
	
	Private Sub detach_Candidatures(ByVal entity As Candidature)
		Me.SendPropertyChanging
		entity.Election = Nothing
	End Sub
End Class

<Table(Name:="dbo.Etudiant")>  _
Partial Public Class Etudiant
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _Matricule As String
	
	Private _Nom As String
	
	Private _Prenom As String
	
	Private _Filiere As String
	
	Private _Specialite As String
	
	Private _Niveau As Integer
	
	Private _Sexe As String
	
	Private _Administrateurs As EntitySet(Of Administrateur)
	
	Private _Votes As EntitySet(Of Vote)
	
	Private _Candidatures As EntitySet(Of Candidature)
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnMatriculeChanging(value As String)
    End Sub
    Partial Private Sub OnMatriculeChanged()
    End Sub
    Partial Private Sub OnNomChanging(value As String)
    End Sub
    Partial Private Sub OnNomChanged()
    End Sub
    Partial Private Sub OnPrenomChanging(value As String)
    End Sub
    Partial Private Sub OnPrenomChanged()
    End Sub
    Partial Private Sub OnFiliereChanging(value As String)
    End Sub
    Partial Private Sub OnFiliereChanged()
    End Sub
    Partial Private Sub OnSpecialiteChanging(value As String)
    End Sub
    Partial Private Sub OnSpecialiteChanged()
    End Sub
    Partial Private Sub OnNiveauChanging(value As Integer)
    End Sub
    Partial Private Sub OnNiveauChanged()
    End Sub
    Partial Private Sub OnSexeChanging(value As String)
    End Sub
    Partial Private Sub OnSexeChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		Me._Administrateurs = New EntitySet(Of Administrateur)(AddressOf Me.attach_Administrateurs, AddressOf Me.detach_Administrateurs)
		Me._Votes = New EntitySet(Of Vote)(AddressOf Me.attach_Votes, AddressOf Me.detach_Votes)
		Me._Candidatures = New EntitySet(Of Candidature)(AddressOf Me.attach_Candidatures, AddressOf Me.detach_Candidatures)
		OnCreated
	End Sub
	
	<Column(Storage:="_Matricule", DbType:="VarChar(50) NOT NULL", CanBeNull:=false, IsPrimaryKey:=true)>  _
	Public Property Matricule() As String
		Get
			Return Me._Matricule
		End Get
		Set
			If (String.Equals(Me._Matricule, value) = false) Then
				Me.OnMatriculeChanging(value)
				Me.SendPropertyChanging
				Me._Matricule = value
				Me.SendPropertyChanged("Matricule")
				Me.OnMatriculeChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Nom", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Nom() As String
		Get
			Return Me._Nom
		End Get
		Set
			If (String.Equals(Me._Nom, value) = false) Then
				Me.OnNomChanging(value)
				Me.SendPropertyChanging
				Me._Nom = value
				Me.SendPropertyChanged("Nom")
				Me.OnNomChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Prenom", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Prenom() As String
		Get
			Return Me._Prenom
		End Get
		Set
			If (String.Equals(Me._Prenom, value) = false) Then
				Me.OnPrenomChanging(value)
				Me.SendPropertyChanging
				Me._Prenom = value
				Me.SendPropertyChanged("Prenom")
				Me.OnPrenomChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Filiere", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Filiere() As String
		Get
			Return Me._Filiere
		End Get
		Set
			If (String.Equals(Me._Filiere, value) = false) Then
				Me.OnFiliereChanging(value)
				Me.SendPropertyChanging
				Me._Filiere = value
				Me.SendPropertyChanged("Filiere")
				Me.OnFiliereChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Specialite", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Specialite() As String
		Get
			Return Me._Specialite
		End Get
		Set
			If (String.Equals(Me._Specialite, value) = false) Then
				Me.OnSpecialiteChanging(value)
				Me.SendPropertyChanging
				Me._Specialite = value
				Me.SendPropertyChanged("Specialite")
				Me.OnSpecialiteChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Niveau", DbType:="Int NOT NULL")>  _
	Public Property Niveau() As Integer
		Get
			Return Me._Niveau
		End Get
		Set
			If ((Me._Niveau = value)  _
						= false) Then
				Me.OnNiveauChanging(value)
				Me.SendPropertyChanging
				Me._Niveau = value
				Me.SendPropertyChanged("Niveau")
				Me.OnNiveauChanged
			End If
		End Set
	End Property
	
	<Column(Storage:="_Sexe", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property Sexe() As String
		Get
			Return Me._Sexe
		End Get
		Set
			If (String.Equals(Me._Sexe, value) = false) Then
				Me.OnSexeChanging(value)
				Me.SendPropertyChanging
				Me._Sexe = value
				Me.SendPropertyChanged("Sexe")
				Me.OnSexeChanged
			End If
		End Set
	End Property
	
	<Association(Name:="Etudiant_Administrateur", Storage:="_Administrateurs", OtherKey:="IdEtud")>  _
	Public Property Administrateurs() As EntitySet(Of Administrateur)
		Get
			Return Me._Administrateurs
		End Get
		Set
			Me._Administrateurs.Assign(value)
		End Set
	End Property
	
	<Association(Name:="Etudiant_Vote", Storage:="_Votes", OtherKey:="Matricule")>  _
	Public Property Votes() As EntitySet(Of Vote)
		Get
			Return Me._Votes
		End Get
		Set
			Me._Votes.Assign(value)
		End Set
	End Property
	
	<Association(Name:="Etudiant_Candidature", Storage:="_Candidatures", OtherKey:="Matricule")>  _
	Public Property Candidatures() As EntitySet(Of Candidature)
		Get
			Return Me._Candidatures
		End Get
		Set
			Me._Candidatures.Assign(value)
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
	
	Private Sub attach_Administrateurs(ByVal entity As Administrateur)
		Me.SendPropertyChanging
		entity.Etudiant = Me
	End Sub
	
	Private Sub detach_Administrateurs(ByVal entity As Administrateur)
		Me.SendPropertyChanging
		entity.Etudiant = Nothing
	End Sub
	
	Private Sub attach_Votes(ByVal entity As Vote)
		Me.SendPropertyChanging
		entity.Etudiant = Me
	End Sub
	
	Private Sub detach_Votes(ByVal entity As Vote)
		Me.SendPropertyChanging
		entity.Etudiant = Nothing
	End Sub
	
	Private Sub attach_Candidatures(ByVal entity As Candidature)
		Me.SendPropertyChanging
		entity.Etudiant = Me
	End Sub
	
	Private Sub detach_Candidatures(ByVal entity As Candidature)
		Me.SendPropertyChanging
		entity.Etudiant = Nothing
	End Sub
End Class