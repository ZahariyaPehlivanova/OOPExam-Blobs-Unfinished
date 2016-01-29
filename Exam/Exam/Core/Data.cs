namespace Exam.Core
{
    using Models;
    using Interfaces;
    using System;
    using System.Collections.Generic;

    public class Data : IData
    {
        private readonly ICollection<IBlob> blobs = new List<IBlob>();
        public Data()
        {
        }
        public IEnumerable<IBlob> Blobs
        {
            get { return this.blobs; }
        }
        public void AddBlob(IBlob blob)
        {
            if (blob == null)
            {
                throw new ArgumentNullException(nameof(blob));
            }
            if (this.blobs.Contains(blob))
            {
                throw new ArgumentException("The blob already exists");
            }
            this.blobs.Add(blob);
        }
    }
}
