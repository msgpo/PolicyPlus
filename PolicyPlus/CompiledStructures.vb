﻿Public Class PolicyPlusCategory
    Public UniqueID As String
    Public Parent As PolicyPlusCategory
    Public Children As New List(Of PolicyPlusCategory)
    Public DisplayName As String
    Public DefinedIn As AdmxFile
    Public RawCategory As AdmxCategory
End Class
