using System.Collections.Generic;

namespace Exam.Interfaces
{
    public interface IData
    {
        IEnumerable<IBlob> Blobs { get; }
        void AddBlob(IBlob blob);
    }
}
