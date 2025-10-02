using Sandcastle.Core.BuildEngine;

using XsdDocumentation.Model;

namespace XsdDocumentation.PlugIn
{
    internal sealed class MessageReporter : IMessageReporter
    {
        private readonly IBuildProcess _buildProcess;

        public MessageReporter(IBuildProcess buildProcess)
        {
            _buildProcess = buildProcess;
        }

        public void ReportWarning(string warningCode, string message)
        {
            _buildProcess.ReportWarning(warningCode, message);
        }
    }
}