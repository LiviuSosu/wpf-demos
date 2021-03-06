#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;

namespace syncfusion.propertygriddemos.wpf
{
    /// <summary>
    /// Interaction logic for BuildInEditorDemo.xaml
    /// </summary>
    public partial class BuildInEditorDemo : DemoControl
    {
        public BuildInEditorDemo()
        {
            InitializeComponent();
        }
        public BuildInEditorDemo(string themename) : base(themename)
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            //Release all managed resources
            if (this.propertygrid != null)
            {
                this.propertygrid.Dispose();
                this.propertygrid = null;
            }

            if (this.SyntaxEditor != null)
            {
                this.SyntaxEditor.Dispose();
                this.SyntaxEditor = null;
            }

            base.Dispose(disposing);
        }
    }
}
