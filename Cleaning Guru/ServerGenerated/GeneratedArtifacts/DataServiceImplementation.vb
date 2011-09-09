'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Namespace LightSwitchApplication.Implementation
    
    <Global.System.ServiceModel.DomainServices.Hosting.EnableClientAccess()> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataDomainService
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DomainService(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New()
            MyBase.New()
        End Sub
    
    #Region "Public methods"
    
    #Region "Cleaner"
    
        Public Sub InsertCleaner(ByVal entity As Global.ApplicationData.Implementation.Cleaner)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.Cleaners.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdateCleaner(ByVal currentEntity As Global.ApplicationData.Implementation.Cleaner)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.Cleaners, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeleteCleaner(ByVal entity As Global.ApplicationData.Implementation.Cleaner)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.Cleaners.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Client"
    
        Public Sub InsertClient(ByVal entity As Global.ApplicationData.Implementation.Client)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.Clients.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdateClient(ByVal currentEntity As Global.ApplicationData.Implementation.Client)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.Clients, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeleteClient(ByVal entity As Global.ApplicationData.Implementation.Client)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.Clients.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Job"
    
        Public Sub InsertJob(ByVal entity As Global.ApplicationData.Implementation.Job)
            If (entity.EntityState <> Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.ObjectStateManager.ChangeObjectState(entity, Global.System.Data.EntityState.Added)
            Else
                Me.ObjectContext.Jobs.AddObject(entity)
            End If
        End Sub
    
        Public Sub UpdateJob(ByVal currentEntity As Global.ApplicationData.Implementation.Job)
            Global.System.ServiceModel.DomainServices.EntityFramework.ObjectContextExtensions.AttachAsModified(Me.ObjectContext.Jobs, currentEntity, Me.ChangeSet.GetOriginal(currentEntity))
        End Sub
    
        Public Sub DeleteJob(ByVal entity As Global.ApplicationData.Implementation.Job)
            If (entity.EntityState = Global.System.Data.EntityState.Detached) Then
                Me.ObjectContext.Jobs.Attach(entity)
            End If
    
            Me.DeleteEntity(entity)
        End Sub
    #End Region
    
    #Region "Queries"
        Public Function Cleaners_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Cleaner)("Cleaners_Single", frameworkOperators, Id)
        End Function
    
        Public Function Cleaners_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Cleaner)("Cleaners_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function Cleaners_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Cleaner)("Cleaners_All", frameworkOperators)
        End Function
    
        Public Function Clients_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Client)("Clients_Single", frameworkOperators, Id)
        End Function
    
        Public Function Clients_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Client)("Clients_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function Clients_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Client)("Clients_All", frameworkOperators)
        End Function
    
        Public Function Jobs_Single(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Job)("Jobs_Single", frameworkOperators, Id)
        End Function
    
        Public Function Jobs_SingleOrDefault(ByVal frameworkOperators As String, ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Job)("Jobs_SingleOrDefault", frameworkOperators, Id)
        End Function
    
        Public Function Jobs_All(ByVal frameworkOperators As String) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Return Me.GetQuery(Of Global.ApplicationData.Implementation.Job)("Jobs_All", frameworkOperators)
        End Function
    
    #End Region
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __GetEntitySetCanInformation(ByVal entitySetName as String) As Integer
            Return MyBase.GetEntitySetCanInformation(entitySetName)
        End Function
    
        <Global.System.ServiceModel.DomainServices.Server.Invoke(HasSideEffects:=False)> _
        Public Function __CanExecuteOperation(ByVal operationName as String) As Boolean
            Return MyBase.CanExecuteOperation(operationName)
        End Function
    
    #End Region
    
        Protected Overrides Function CreateDataService() As Global.Microsoft.LightSwitch.IDataService
            Return New Global.LightSwitchApplication.DataWorkspace().ApplicationData
        End Function
    
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class ApplicationDataServiceImplementation
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceImplementation(Of Global.ApplicationData.Implementation.ApplicationDataObjectContext)
    
        Public Sub New(ByVal dataService As Global.Microsoft.LightSwitch.IDataService)
            MyBase.New(dataService)
        End Sub
    
    #Region "Queries"
        Public Function Cleaners_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Cleaner)("Cleaners_All"), _
                Function(c) (Id.HasValue AndAlso CBool((c.Id = Id))))
            Return query
        End Function
    
        Public Function Cleaners_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Cleaner)("Cleaners_All"), _
                Function(c) (Id.HasValue AndAlso CBool((c.Id = Id))))
            Return query
        End Function
    
        Public Function Cleaners_All() As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Cleaner)
            query = MyBase.CreateQuery(Of Global.ApplicationData.Implementation.Cleaner)("[Cleaners]").AsQueryable()
            Return query
        End Function
    
        Public Function Clients_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Client)("Clients_All"), _
                Function(c) (Id.HasValue AndAlso CBool((c.Id = Id))))
            Return query
        End Function
    
        Public Function Clients_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Client)("Clients_All"), _
                Function(c) (Id.HasValue AndAlso CBool((c.Id = Id))))
            Return query
        End Function
    
        Public Function Clients_All() As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Client)
            query = MyBase.CreateQuery(Of Global.ApplicationData.Implementation.Client)("[Clients]").AsQueryable()
            Return query
        End Function
    
        Public Function Jobs_Single(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Job)("Jobs_All"), _
                Function(j) (Id.HasValue AndAlso CBool((j.Id = Id))))
            Return query
        End Function
    
        Public Function Jobs_SingleOrDefault(ByVal Id As Global.System.Nullable(Of Integer)) As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            query = Global.System.Linq.Queryable.Where( _
                Me.GetQuery(Of Global.ApplicationData.Implementation.Job)("Jobs_All"), _
                Function(j) (Id.HasValue AndAlso CBool((j.Id = Id))))
            Return query
        End Function
    
        Public Function Jobs_All() As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            Dim query As Global.System.Linq.IQueryable(Of Global.ApplicationData.Implementation.Job)
            query = MyBase.CreateQuery(Of Global.ApplicationData.Implementation.Job)("[Jobs]").AsQueryable()
            Return query
        End Function
    
    #End Region

    #Region "Protected methods"
        Protected Overrides Function CreateObject(ByVal type As Global.System.Type) As Object
            If (type Is GetType(Global.ApplicationData.Implementation.Cleaner)) Then
                Return New Global.ApplicationData.Implementation.Cleaner
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.Client)) Then
                Return New Global.ApplicationData.Implementation.Client
            End If
            If (type Is GetType(Global.ApplicationData.Implementation.Job)) Then
                Return New Global.ApplicationData.Implementation.Job
            End If
    
            Return MyBase.CreateObject(type)
        End Function
    
        Protected Overrides Function CreateObjectContext() As Global.ApplicationData.Implementation.ApplicationDataObjectContext
            Return New Global.ApplicationData.Implementation.ApplicationDataObjectContext(MyBase.GetEntityConnectionString( _
                "_IntrinsicData", _
                "res://*/ApplicationData.csdl|res://*/ApplicationData.ssdl|res://*/ApplicationData.msl", _
                "System.Data.SqlClient"))
        End Function
    
        Protected Overrides Function CreateEntityImplementation(Of T As Global.Microsoft.LightSwitch.IEntityObject)() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Cleaner)) Then
                Return New Global.ApplicationData.Implementation.Cleaner()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Client)) Then
                Return New Global.ApplicationData.Implementation.Client()
            End If
            If GetType(T).Equals(GetType(Global.LightSwitchApplication.Job)) Then
                Return New Global.ApplicationData.Implementation.Job()
            End If
            Return Nothing
        End Function
    
    #End Region
    
    End Class
    
    #Region "DataServiceImplementationFactory"
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.IDataServiceFactory))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class DataServiceFactory
        Inherits Global.Microsoft.LightSwitch.ServerGenerated.Implementation.DataServiceFactory
    
        Protected Overrides Function CreateDataService(ByVal dataServiceType As Global.System.Type) As Global.Microsoft.LightSwitch.IDataService
            If dataServiceType.Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.ApplicationDataService()
            End If
            Return MyBase.CreateDataService(dataServiceType)
        End Function
    
        Protected Overrides Function CreateDataServiceImplementation(Of TDataService As Global.Microsoft.LightSwitch.IDataService)(ByVal dataService As TDataService) As Global.Microsoft.LightSwitch.Internal.IDataServiceImplementation
            If GetType(TDataService).Equals(GetType(Global.LightSwitchApplication.ApplicationData)) Then
                Return New Global.LightSwitchApplication.Implementation.ApplicationDataServiceImplementation(dataService)
            End If
            Return MyBase.CreateDataServiceImplementation(dataService)
        End Function
    End Class
    #End Region
    
    <Global.System.ComponentModel.Composition.PartCreationPolicy(Global.System.ComponentModel.Composition.CreationPolicy.Shared)> _
    <Global.System.ComponentModel.Composition.Export(GetType(Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider))> _
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Public Class __TypeMapping
        Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider
        Private Function GetImplementationType(ByVal definitionType As Global.System.Type) As Global.System.Type Implements Global.Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType
            If GetType(Global.LightSwitchApplication.Cleaner).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Cleaner)
            End If
            If GetType(Global.LightSwitchApplication.Client).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Client)
            End If
            If GetType(Global.LightSwitchApplication.Job).Equals(definitionType)
                Return GetType(Global.ApplicationData.Implementation.Job)
            End If
            Return Nothing
        End Function
    End Class
End Namespace

Namespace ApplicationData.Implementation

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Cleaner
        Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _QueryStringImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.QueryString
            Get
                Return Me.QueryString
            End Get
            Set(ByVal value As String)
                Me.QueryString = value
            End Set
        End Property
        
        Private Property _FirstNameImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.FirstName
            Get
                Return Me.FirstName
            End Get
            Set(ByVal value As String)
                Me.FirstName = value
            End Set
        End Property
        
        Private Property _LastNameImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.LastName
            Get
                Return Me.LastName
            End Get
            Set(ByVal value As String)
                Me.LastName = value
            End Set
        End Property
        
        Private Property _HourlyRateImplementation() As Decimal Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.HourlyRate
            Get
                Return Me.HourlyRate
            End Get
            Set(ByVal value As Decimal)
                Me.HourlyRate = value
            End Set
        End Property
        
        Private Property _StartDateImplementation() As Date Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.StartDate
            Get
                Return Me.StartDate
            End Get
            Set(ByVal value As Date)
                Me.StartDate = value
            End Set
        End Property
        
        Private Property _EndDateImplementation() As Global.System.Nullable(Of Date) Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.EndDate
            Get
                Return Me.EndDate
            End Get
            Set(ByVal value As Global.System.Nullable(Of Date))
                Me.EndDate = value
            End Set
        End Property
        
        Private Property _PhoneImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.Phone
            Get
                Return Me.Phone
            End Get
            Set(ByVal value As String)
                Me.Phone = value
            End Set
        End Property
        
        Private Property _EmailImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.Email
            Get
                Return Me.Email
            End Get
            Set(ByVal value As String)
                Me.Email = value
            End Set
        End Property
        
        Private Property _AddressLine1Implementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.AddressLine1
            Get
                Return Me.AddressLine1
            End Get
            Set(ByVal value As String)
                Me.AddressLine1 = value
            End Set
        End Property
        
        Private Property _AddressLine2Implementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.AddressLine2
            Get
                Return Me.AddressLine2
            End Get
            Set(ByVal value As String)
                Me.AddressLine2 = value
            End Set
        End Property
        
        Private Property _CityImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.City
            Get
                Return Me.City
            End Get
            Set(ByVal value As String)
                Me.City = value
            End Set
        End Property
        
        Private Property _PostcodeImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.Postcode
            Get
                Return Me.Postcode
            End Get
            Set(ByVal value As String)
                Me.Postcode = value
            End Set
        End Property
        
        Private Property _CountryRegionImplementation() As String Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.CountryRegion
            Get
                Return Me.CountryRegion
            End Get
            Set(ByVal value As String)
                Me.CountryRegion = value
            End Set
        End Property
        
        Private ReadOnly Property _JobsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Cleaner.DetailsClass.IImplementation.Jobs
            Get
                Return Me.Jobs
            End Get
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    Partial Public Class Client
        Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _NameImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Name
            Get
                Return Me.Name
            End Get
            Set(ByVal value As String)
                Me.Name = value
            End Set
        End Property
        
        Private Property _Address1Implementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Address1
            Get
                Return Me.Address1
            End Get
            Set(ByVal value As String)
                Me.Address1 = value
            End Set
        End Property
        
        Private Property _Address2Implementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Address2
            Get
                Return Me.Address2
            End Get
            Set(ByVal value As String)
                Me.Address2 = value
            End Set
        End Property
        
        Private Property _CityImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.City
            Get
                Return Me.City
            End Get
            Set(ByVal value As String)
                Me.City = value
            End Set
        End Property
        
        Private Property _PostcodeImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Postcode
            Get
                Return Me.Postcode
            End Get
            Set(ByVal value As String)
                Me.Postcode = value
            End Set
        End Property
        
        Private Property _RegionImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Region
            Get
                Return Me.Region
            End Get
            Set(ByVal value As String)
                Me.Region = value
            End Set
        End Property
        
        Private Property _PhoneImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Phone
            Get
                Return Me.Phone
            End Get
            Set(ByVal value As String)
                Me.Phone = value
            End Set
        End Property
        
        Private Property _EmailImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Email
            Get
                Return Me.Email
            End Get
            Set(ByVal value As String)
                Me.Email = value
            End Set
        End Property
        
        Private Property _QueryStringImplementation() As String Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.QueryString
            Get
                Return Me.QueryString
            End Get
            Set(ByVal value As String)
                Me.QueryString = value
            End Set
        End Property
        
        Private ReadOnly Property _JobsImplementation() As Global.System.Collections.IEnumerable Implements Global.LightSwitchApplication.Client.DetailsClass.IImplementation.Jobs
            Get
                Return Me.Jobs
            End Get
        End Property
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
    End Class
    
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "10.0.0.0")> _
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()> _
    <Global.System.ComponentModel.DataAnnotations.MetadataType(GetType(Global.ApplicationData.Implementation.Job.Metadata))> _
    Partial Public Class Job
        Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation

        Private Property _IdImplementation() As Integer Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Id
            Get
                Return Me.Id
            End Get
            Set(ByVal value As Integer)
                Me.Id = value
            End Set
        End Property
        
        Private Property _StartTimeImplementation() As Date Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.StartTime
            Get
                Return Me.StartTime
            End Get
            Set(ByVal value As Date)
                Me.StartTime = value
            End Set
        End Property
        
        Private Property _EndTimeImplementation() As Date Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.EndTime
            Get
                Return Me.EndTime
            End Get
            Set(ByVal value As Date)
                Me.EndTime = value
            End Set
        End Property
        
        Private Property _PriceImplementation() As Decimal Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Price
            Get
                Return Me.Price
            End Get
            Set(ByVal value As Decimal)
                Me.Price = value
            End Set
        End Property
        
        Private Property _CleanersRateImplementation() As Decimal Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.CleanersRate
            Get
                Return Me.CleanersRate
            End Get
            Set(ByVal value As Decimal)
                Me.CleanersRate = value
            End Set
        End Property
        
        Private Property _PerPeriodImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.PerPeriod
            Get
                Return Me.PerPeriod
            End Get
            Set(ByVal value As String)
                Me.PerPeriod = value
            End Set
        End Property
        
        Private Property _RecuranceImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Recurance
            Get
                Return Me.Recurance
            End Get
            Set(ByVal value As String)
                Me.Recurance = value
            End Set
        End Property
        
        Private Property _NoteImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Note
            Get
                Return Me.Note
            End Get
            Set(ByVal value As String)
                Me.Note = value
            End Set
        End Property
        
        Private Property _QueryStringImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.QueryString
            Get
                Return Me.QueryString
            End Get
            Set(ByVal value As String)
                Me.QueryString = value
            End Set
        End Property
        
        Private Property _IsDeletedImplementation() As Boolean Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.IsDeleted
            Get
                Return Me.IsDeleted
            End Get
            Set(ByVal value As Boolean)
                Me.IsDeleted = value
            End Set
        End Property
        
        Private Property _StreetAddress1Implementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.StreetAddress1
            Get
                Return Me.StreetAddress1
            End Get
            Set(ByVal value As String)
                Me.StreetAddress1 = value
            End Set
        End Property
        
        Private Property _StreetAddress2Implementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.StreetAddress2
            Get
                Return Me.StreetAddress2
            End Get
            Set(ByVal value As String)
                Me.StreetAddress2 = value
            End Set
        End Property
        
        Private Property _CityImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.City
            Get
                Return Me.City
            End Get
            Set(ByVal value As String)
                Me.City = value
            End Set
        End Property
        
        Private Property _PostcodeImplementation() As String Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Postcode
            Get
                Return Me.Postcode
            End Get
            Set(ByVal value As String)
                Me.Postcode = value
            End Set
        End Property
        
        Private Property _CleanerImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Cleaner
            Get
                Return Me.Cleaner
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Cleaner = DirectCast(value, Global.ApplicationData.Implementation.Cleaner)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Cleaner")
                End If
            End Set
        End Property
        
        Private Sub OnJob_CleanerChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Cleaner")
            End If
        End Sub
        
        Private Property _ClientImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementation Implements Global.LightSwitchApplication.Job.DetailsClass.IImplementation.Client
            Get
                Return Me.Client
            End Get
            Set(ByVal value As Global.Microsoft.LightSwitch.Internal.IEntityImplementation)
                Me.Client = DirectCast(value, Global.ApplicationData.Implementation.Client)
                If Me.__host IsNot Nothing Then
                    Me.__host.RaisePropertyChanged("Client")
                End If
            End Set
        End Property
        
        Private Sub OnJob_ClientChanged()
            If Me.__host IsNot Nothing Then
                Me.__host.RaisePropertyChanged("Client")
            End If
        End Sub
        
        #Region "IEntityImplementation Members"
        Private __host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost
        
        Private ReadOnly Property __HostImplementation() As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Host
            Get
                Return Me.__host
            End Get
        End Property
        
        Private Sub _Initialize(ByVal host As Global.Microsoft.LightSwitch.Internal.IEntityImplementationHost) Implements Global.Microsoft.LightSwitch.Internal.IEntityImplementation.Initialize
            Me.__host = host
        End Sub
        
        Protected Overrides Sub OnPropertyChanged(ByVal propertyName As String)
            MyBase.OnPropertyChanged(propertyName)
        
            If Not Me.__host Is Nothing Then
                Me.__host.RaisePropertyChanged(propertyName)
            End If
        End Sub
        #End Region
        
        Friend Class Metadata
        
            <Global.System.ServiceModel.DomainServices.Server.Include> _
            Public Property Cleaner As Global.ApplicationData.Implementation.Cleaner
        
            <Global.System.ServiceModel.DomainServices.Server.Include> _
            Public Property Client As Global.ApplicationData.Implementation.Client
        
        End Class
    End Class
    
End Namespace

