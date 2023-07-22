import './Header.css'
import HeaderLogo from '../HeaderLogo/HeaderLogo'
import HeaderMenu from '../HeaderMenu/HeaderMenu'
import HeaderSocials from '../HeaderSocials/HeaderSocials';

export default function Header() {
    return (
        <div className='header'>
            <div className='header-container'>
                <HeaderLogo />

                <HeaderMenu />

                <HeaderSocials />
            </div>
        </div>
    );
}
