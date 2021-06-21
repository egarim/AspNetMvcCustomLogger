using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;

namespace AspNetMvcCustomLogger
{
    public class CustomTextWriterTraceListener : TextWriterTraceListener
    {
        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class with <see cref="System.IO.TextWriter" /> as the output recipient.</summary>
        public CustomTextWriterTraceListener()
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class, using the stream as the recipient of the debugging and tracing output.</summary>
        /// <param name="stream">A <see cref="System.IO.Stream" /> that represents the stream the <see cref="CustomTextWriterTraceListener" /> writes to. </param>
        /// <exception cref="System.ArgumentNullException">The stream is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(Stream stream) : base(stream)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class with the specified name, using the stream as the recipient of the debugging and tracing output.</summary>
        /// <param name="stream">A <see cref="System.IO.Stream" /> that represents the stream the <see cref="CustomTextWriterTraceListener" /> writes to. </param>
        /// <param name="name">The name of the new instance. </param>
        /// <exception cref="System.ArgumentNullException">The stream is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(Stream stream, string name) : base(stream, name)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class using the specified writer as recipient of the tracing or debugging output.</summary>
        /// <param name="writer">A <see cref="System.IO.TextWriter" /> that receives the output from the <see cref="CustomTextWriterTraceListener" />. </param>
        /// <exception cref="System.ArgumentNullException">The writer is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(TextWriter writer) : base(writer)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class with the specified name, using the specified writer as recipient of the tracing or debugging output.</summary>
        /// <param name="writer">A <see cref="System.IO.TextWriter" /> that receives the output from the <see cref="CustomTextWriterTraceListener" />. </param>
        /// <param name="name">The name of the new instance. </param>
        /// <exception cref="System.ArgumentNullException">The writer is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(TextWriter writer, string name) : base(writer, name)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class, using the file as the recipient of the debugging and tracing output.</summary>
        /// <param name="fileName">The name of the file the <see cref="CustomTextWriterTraceListener" /> writes to. </param>
        /// <exception cref="System.ArgumentNullException">The file is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(string fileName) : base(fileName)
        {

        }

        /// <summary>Initializes a new instance of the <see cref="CustomTextWriterTraceListener" /> class with the specified name, using the file as the recipient of the debugging and tracing output.</summary>
        /// <param name="fileName">The name of the file the <see cref="CustomTextWriterTraceListener" /> writes to. </param>
        /// <param name="name">The name of the new instance. </param>
        /// <exception cref="System.ArgumentNullException">The stream is <see langword="null" />. </exception>
        public CustomTextWriterTraceListener(string fileName, string name) : base(fileName, name)
        {

        }
        //public CustomTextWriterTraceListener(string fileName) : base(fileName)
    }
}