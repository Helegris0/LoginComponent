using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginService {
    public abstract class Loader<T> {
        protected string sourcePath;
        protected IContentReader contentReader;

        public Loader(string sourcePath, IContentReader contentReader) {
            this.sourcePath = sourcePath;
            this.contentReader = contentReader;
        }

        abstract public List<T> LoadUsers();
    }
}
