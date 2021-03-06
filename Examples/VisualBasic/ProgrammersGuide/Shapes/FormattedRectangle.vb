'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Slides. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Slides
Imports System.Drawing

Namespace VisualBasic.Shapes
    Public Class FormattedRectangle
        Public Shared Sub Run()
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Shapes()

            ' Create directory if it is not already present.
            Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
            If (Not IsExists) Then
                System.IO.Directory.CreateDirectory(dataDir)
            End If

            'Instantiate Prseetation class that represents the PPTX
            Using pres As New Presentation()

                'Get the first slide
                Dim sld As ISlide = pres.Slides(0)

                'Add autoshape of rectangle type
                Dim shp As IShape = sld.Shapes.AddAutoShape(ShapeType.Rectangle, 50, 150, 150, 50)

                'Apply some formatting to rectangle shape
                shp.FillFormat.FillType = FillType.Solid
                shp.FillFormat.SolidFillColor.Color = Color.Chocolate

                'Apply some formatting to the line of rectangle
                shp.LineFormat.FillFormat.FillType = FillType.Solid
                shp.LineFormat.FillFormat.SolidFillColor.Color = Color.Black
                shp.LineFormat.Width = 5

                'Write the PPTX file to disk
                pres.Save(dataDir & "RectShp2.pptx", Aspose.Slides.Export.SaveFormat.Pptx)
            End Using

        End Sub
    End Class
End Namespace