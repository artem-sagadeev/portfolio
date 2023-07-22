import './HeaderSocials.css'
import { ReactComponent as TelegramLogo } from '../../../assets/telegram.svg'

export default function HeaderSocials() {
    return (
        <div className='header-right'>
            <a href="https://t.me/polakalinina">
                <TelegramLogo />
            </a>
        </div>
    );
}
