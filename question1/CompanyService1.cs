public class CompanyService {
    Dependency _dependency;
    public CompanyService(Dependency dependency) {
        _dependency = dependency;
    }
}

public class OtherCompanyService {
    Dependency _dependency;
    public OtherCompanyService() {
        _dependency = new Dependency();
    }
}

public class Dependency {
    // DEPENDENCY IMPLEMENTATION GOES HERE.
}