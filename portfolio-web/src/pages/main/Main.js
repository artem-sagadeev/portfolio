import Header from '../../components/Layout/Header/Header';
import About from '../../components/About/About';
import Contacts from '../../components/Contacts/Contacts';
import CasesList from '../../components/Cases/CasesList/CasesList';

export default function Main() {
    return (
        <div>
            <Header />
            <About />
            <CasesList />
            <Contacts />
        </div>
    );
}
