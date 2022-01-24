Public Class M_School
#Region "LoginData"

#Region "Variable Declaration"
    Private m_Username
    Private m_Password
    Private m_Position
    Private m_keepMeLogin
    Private m_phoneNumber
    Private m_email
    Private m_nrc
    Private m_mother
    Private m_father
#End Region

#Region "Constructors and Destructors"
    Private Sub M_School()
        m_Username = ""
        m_Password = ""
        m_Position = ""
        m_phoneNumber = ""
        m_keepMeLogin = 0
        m_email = ""
        m_nrc = ""
        m_mother = ""
        m_father = ""
    End Sub

    Private Sub M_School(ByVal username As String, ByVal password As String, ByVal position As String, ByVal keepMeLogin As Boolean, ByVal phoneNumber As Integer, ByVal email As String, ByVal mother As String, ByVal father As String, ByVal nrc As String)
        m_Username = username
        m_Password = password
        m_Position = position
        m_keepMeLogin = keepMeLogin
        m_phoneNumber = phoneNumber
        m_email = email
        m_nrc = nrc
        m_mother = mother
        m_father = father
    End Sub
#End Region

#Region "Properties"
    Public Property Username() As String
        Get
            Return Me.m_Username
        End Get
        Set(ByVal value As String)
            Me.m_Username = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Me.m_Password
        End Get
        Set(ByVal value As String)
            Me.m_Password = value
        End Set
    End Property

    Public Property Position() As String
        Get
            Return Me.m_Position
        End Get
        Set(ByVal value As String)
            Me.m_Position = value
        End Set
    End Property

    Public Property keepMeLogin() As Boolean
        Get
            Return Me.m_keepMeLogin
        End Get
        Set(ByVal value As Boolean)
            Me.m_keepMeLogin = value
        End Set
    End Property

    Public Property phoneNumber() As String
        Get
            Return Me.m_phoneNumber
        End Get
        Set(ByVal value As String)
            Me.m_phoneNumber = value
        End Set
    End Property

    Public Property email() As String
        Get
            Return Me.m_email
        End Get
        Set(ByVal value As string)
            Me.m_email = value
        End Set
    End Property
    Public Property father() As String
        Get
            Return Me.m_father
        End Get
        Set(ByVal value As String)
            Me.m_father = value
        End Set
    End Property
    Public Property mother() As String
        Get
            Return Me.m_mother
        End Get
        Set(ByVal value As String)
            Me.m_mother = value
        End Set
    End Property

    Public Property nrc() As String
        Get
            Return Me.m_nrc
        End Get
        Set(ByVal value As String)
            Me.m_nrc = value
        End Set

    End Property

#End Region
#End Region


#Region ""
    'Main Form
#End Region

End Class
