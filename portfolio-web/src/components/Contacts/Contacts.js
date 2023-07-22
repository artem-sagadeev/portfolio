import './Contacts.css'

export default function Contacts() {
    return (
        <div className='contacts'>
            <div className='contacts-container'>
                <div className='contacts-text'>
                    <span>По всем вопросам свяжитесь со мной любым удобным способом:</span>
                    <br/>
                    <br/>
                    E-mail: pvkalininapv@gmail.com
                    <br/>
                    <a className='contacts-telegram-link' href='http://t.me/polakalinina'>Telegram: @polakalinina</a>
                </div>
            </div>
        </div>
    );
}
