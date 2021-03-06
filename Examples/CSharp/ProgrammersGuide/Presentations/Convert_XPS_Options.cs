//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Slides. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Slides;

namespace CSharp.Presentations
{
    public class Convert_XPS_Options
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Presentations();

            //Instantiate a Presentation object that represents a presentation file
            using (Presentation pres = new Presentation(dataDir + "Convert_XPS_Options.pptx"))
            {
                //Instantiate the TiffOptions class
                Aspose.Slides.Export.XpsOptions opts = new Aspose.Slides.Export.XpsOptions();

                //Save MetaFiles as PNG
                opts.SaveMetafilesAsPng = true;

                //Save the presentation to XPS document
                pres.Save(dataDir + "demo.xps", Aspose.Slides.Export.SaveFormat.Xps, opts);
            }
        }
    }
}