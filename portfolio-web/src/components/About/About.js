import './About.css'
import image from '../../assets/about.jpg'

export default function About() {
    return (
        <div className='about'>
            <div className='about-container'>
                <div className='about-left'>
                    <img src={image}/>
                </div>
                <div className='about-right'>
                    <div className='about-name'>
                        Полина Калинина
                    </div>
                    <div className='about-job'>
                        дизайнер онлайн-продуктов
                    </div>
                    <div className='about-separator'></div>
                    <div className='about-description'>
                        Работаю над дизайном лендингов, сайтов, баннеров, презентаций, фирменного стиля, рекламных креативов.
                    </div>
                </div>
            </div>
        </div>
    );
}
