import './HeaderMenu.css'

export default function HeaderMenu() {
    return (
        <div className='header-central'>
            <nav className='header-nav'>
                <ul className='header-nav-list'>
                    <li className='header-nav-element'>
                        <a className='header-nav-link'>
                            Обо мне
                        </a>
                    </li>
                    <li className='header-nav-element'>
                        <a className='header-nav-link'>
                            Портфолио
                        </a>
                    </li>
                    <li className='header-nav-element'>
                        <a className='header-nav-link'>
                            Контакты
                        </a>
                    </li>
                </ul>
            </nav>
        </div>
    );
}
