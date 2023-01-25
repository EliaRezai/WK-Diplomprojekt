<template>
    <div class="homeView">
        <div class="text-box">
            <h1>Ihre Physiotherapie Innere Stadt</h1>
            <p>
                Die Physiotherapeuten unserer Wiener Praxis verfolgen das Ziel, die Bewegungs- und Funktionsfähigkeit deiner Gelenke und des gesamten Bewegungsapparates bei <br />
                Beschwerden, Schmerzen oder nach Verletzungen und Unfällen zu verbessern bzw. wiederherzustellen.
            </p>
            <a href="" class="hero-btn">PHSIOTHRAPIE BEGINNEN</a>
        </div>

        <div class="c">
            <p></p>
            <iframe
                src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2657.1594957023185!2d16.433774915531757!3d48.24205707923181!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x476d06b8acf43aeb%3A0x45d393da8933bc6!2sWestfield%20Donau%20Zentrum!5e0!3m2!1sde!2sat!4v1670019399440!5m2!1sde!2sat"
                width="600"
                height="450"
                style="border: 0"
                allowfullscreen=""
                loading="lazy"
                referrerpolicy="no-referrer-when-downgrade"
            ></iframe>
        </div>

        <!--Course-->

        <div class="course">
            <h1>DAS ZIEL UNSERER PHYSIOTHERAPIE</h1>
            <p>
                Unser Team geht es an Spezialisten der Ursache deiner Probleme auf den Grund und sorgt in der angenehmen Atmosphäre unserer Praxis mit individuellen<br />
                Behandlungsmethoden dafür, dass du dich schon bald wieder weitgehend beschwerdefrei bewegen kannst.
            </p>
            <div class="row">
                <div class="course-col">
                    <h3>Termin buchen</h3>
                    <p>Buche jetzt ein Termin und nur nach wenigen Therapie-Einheiten wirst du bereits spürbare Ergebnisse wahrnehmen</p>
                </div>
                <div class="course-col">
                    <h3>Tipps zu Übungen</h3>
                    <p>Um beste Ergebnisse bei der Genesung zu erzielen, gehen wir nach einem Behandlungskonzept vor, das auf zwei wesentlichen Säulen beruht.</p>
                </div>
                <div class="course-col">
                    <h3>Wichtige Infos</h3>
                    <p>Die Aktivierung der körpereigenen Heilkräfte Die Unterstützung der Regeneration durch selbstständige Durchführung</p>
                </div>
            </div>
        </div>

        <!---------------- facilities ------------->

        <div class="facilities">
            <h1>Wir aktivieren deine körpereigenen Heilkräfte</h1>
            <p>
                und helfen deinem Körper, sich selbst zu heilen. Die Physiotherapeuten setzen durch natürliche Reize die körpereigenen Heilkräfte in Gang und leiten dadurch den Heilungsprozess ein
                oder beschleunigen diesen.
            </p>

            <div class="row">
                <div class="facilities-col">
                    <img src="@/assets/images/44.jpg" />
                    <h3>Physio Übungen</h3>
                    <p>
                        die du begleitend zur Behandlung in unserer Praxis in Wien zu Hause durchführen kannst. Unser Team ist darauf spezialisiert, nicht nur eine kurzfristige Erleichterung zu
                        verschaffen, sondern dich dabei zu unterstützen, langfristig schmerzen
                    </p>
                </div>
                <div class="facilities-col">
                    <img src="@/assets/images/77.jpg" />
                    <h3>Individuellbehandlung</h3>
                    <p>
                        Am Beginn der Physiotherapie steht eine persönliche Befunderhebung und detaillierte Diagnose , in welcher der Therapeut/die Therapeutin alle relevanten Informationen sammelt.
                    </p>
                </div>
                <div class="facilities-col">
                    <img src="@/assets/images/44.jpg" />
                    <h3>Hilfe zur Selbsthilfe</h3>
                    <p>Als verantwortungsvolle Therapeuten machen wir unsere Patienten nicht von uns abhängig, sondern zeigen Mittel und Wege auf, wie du dir selbst helfen kannst.</p>
                </div>
            </div>
        </div>

        <!------------------ campus ----------->

        <div class="campus">
            <h1>Unsere Physiotherapeuten in Wien</h1>
            <p>
                Aufgrund unterschiedlicher Spezialisierungen bietet das Team ein breites Behandlungsspektrum gegen Schmerzen, Funktionsstörungen und Erkrankungen des Bewegungsapparates und hilft auf
                diese Weise, dessen Gesundheit wiederherzustellen!
            </p>
            <div class="row">
                <div class="campus-col">
                    <img src="@/assets/images/22.jpg" />
                    <div class="layer">
                        <h3>Dr. Frau Musterman</h3>
                    </div>
                </div>
                <div class="campus-col">
                    <img src="@/assets/images/22.jpg" />
                    <div class="layer">
                        <h3>Dr. Frau Musterman</h3>
                    </div>
                </div>
                <div class="campus-col">
                    <img src="@/assets/images/22.jpg" />
                    <div class="layer">
                        <h3>Dr. Frau Musterman</h3>
                    </div>
                </div>
            </div>
        </div>

        <!------- contact ------>

        <div class="cta">
            <h1>Buchen Sie sich Ihren freien Termin</h1>
            <a href="" class="hero-btn">Termin buchen</a>
        </div>

        <!------- footer ------>

        <div class="footer">
            <div class="col-1">
                <h3>Wichtige Links</h3>
                <a href="#">Startseite</a>
                <a href="#">Praxis</a>
                <a href="#">Therapien</a>
                <a href="#">Öffnungszeiten</a>
            </div>

            <div class="col-2">
                <h3>NEWSLETTER</h3>
                <form>
                    <input type="email" placeholder="Ihre Email Adresse" required />
                    <br />
                    <button type="submit">Senden</button>
                </form>
            </div>

            <div class="col-3">
                <h3>Kontakte</h3>

                <p>
                    Alte Poststraße 14e <br />
                    Maria Ellend 2402 Österreich <br />
                    +43 676 3285511
                </p>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name: 'HomeView',
    components: {},
};
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
.text-box {
    width: 90%;
    color: aliceblue;
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    text-align: center;
}
.text-box h1 {
    font-size: 62px;
}

.text-box p {
    margin: 10px 0 40px;
    font-size: 14px;
    color: aliceblue;
}

.hero-btn {
    display: inline-block;
    text-decoration: none;
    color: #dee3e7;
    border: 1px solid #dadee1;
    padding: 12px 34px;
    font-size: 13px;
    background: transparent;
    position: relative;
    cursor: pointer;
}
.hero-btn:hover {
    border: #89c0e3;
    background: #89c0e3;
    transform: 2s;
}

@media (max-width: 700px) {
    .text-box h1 {
        font-size: 20px;
    }
    .nav-links {
        position: absolute;
        background: #89c0e3;
        height: 100vh;
        width: 200px;
        top: 0;
        right: 0;
        text-align: left;
        z-index: 2;
    }
}

/* ----------- course -------------*/

.course {
    width: 90%;
    margin: auto;
    text-align: center;
    padding-top: 100px;
}

h1 {
    font-size: 36px;
    font-weight: 600;
}

p {
    color: #777;
    font-size: 14px;
    font-weight: 300;
    line-height: 22px;
    padding: 10px;
}

.row {
    margin-top: 5%;
    display: flex;
    justify-content: space-between;
}

.course-col {
    flex-basis: 31%;
    background: #a6d7e27c;
    border-radius: 10px;
    margin-bottom: 5%;
    padding: 20px 12px;
    box-sizing: border-box;
    transform: 1s;
}

h3 {
    text-align: center;
    font-weight: 600;
    margin: 10px 0;
}

.course-col:hover {
    box-shadow: 0 0 20px rgba(172, 205, 234, 0.817);
}

@media (max-width: 700px) {
    .row {
        flex-direction: column;
    }
}

/* ------- campus -------*/

.campus {
    width: 80%;
    margin: auto;
    text-align: center;
    padding: 50px;
}

.campus-col {
    flex-basis: 32%;
    border-radius: 10px;
    margin-bottom: 30px;
    position: relative;
    overflow: hidden;
}

.campus-col img {
    /*------
  widows: 100%;----*/
    width: 100%;
}

.layer {
    background: transparent;
    height: 100%;
    width: 100%;
    position: absolute;
    top: 0;
    left: 0;
    transition: 0.5s;
}

.layer:hover {
    background: rgba(179, 207, 245, 0.58);
}

.layer h3 {
    width: 100%;
    font-weight: 500;
    color: #fff;
    font-size: 26px;
    bottom: 0;
    left: 50%;
    transform: translateX(-50%);
    position: absolute;
}

.layer:hover h3 {
    bottom: 49%;
    opacity: 1;
}

/* facilitis */

.facilities {
    width: 80%;
    margin: auto;
    text-align: center;
    padding-top: 100px;
}

.facilities-col {
    flex-basis: 31%;
    border-radius: 10px;
    margin-bottom: 5%;
    text-align: left;
}

.facilities-col img {
    width: 100%;
    border-radius: 10px;
}

.facilities-col p {
    padding: 0;
}

.facilities-col h3 {
    margin-top: 16px;
    margin-bottom: 15px;
    text-align: left;
}

/*------------------- t -------*/

.testimonials {
    width: 80%;
    margin: auto;
    padding-top: 100px;
    text-align: center;
}

.testimonial-col {
    flex-basis: 44%;
    border-radius: 10px;
    margin-bottom: 5%;
    text-align: left;
    background: #89c0e3;
    padding: 25%;
    cursor: pointer;
    display: flex;
}

.testimonial-col img {
    height: 40px;
    margin-left: 5px;
    margin-right: 30px;
    border-radius: 50%;
}

.testimonial-col p {
    padding: 0;
}

.testimonial-col h3 {
    margin-top: 15px;
    text-align: left;
}

/* fotter*/

.cta {
    margin: 100px auto;
    width: 80%;
    background-image: linear-gradient(rgba(0, 0, 0, 0.7), rgba(0, 0, 0, 0.7)), url('@/assets/images/55.jpg');
    background-position: center;
    background-size: cover;
    border-radius: 10px;
    text-align: center;
    padding: 100px 0;
}

.cta h1 {
    color: #edf0f3;
    margin-bottom: 40px;
    padding: 0;
}

@media (max-width: 700px) {
    .cta h1 {
        font-size: 24px;
    }
}

.footer {
    margin-top: 150px;
    width: 100%;
    padding: 100px 15%;
    color: #efefef;
    background-color: rgb(43, 38, 38);
    display: flex;
}

.footer div {
    text-align: center;
}

.col-2 {
    flex-grow: 2;
}

.footer div h3 {
    font-weight: 300;
    margin-bottom: 30px;
    letter-spacing: 1px;
}

.col-1 a {
    display: block;
    text-decoration: none;
    color: #dadee1;
    margin-bottom: 10px;
}

.col-3 a {
    display: block;
    text-decoration: none;
    color: #dadee1;
    margin-bottom: 10px;
}

.col-3 p {
    display: block;
    text-decoration: none;
    color: #dadee1;
    margin-bottom: 10px;
}

form input {
    width: 400px;
    height: 45px;
    border-radius: 4px;
    text-align: center;
    margin-top: 20px;
    margin-bottom: 40px;
    outline: none;
    border: none;
}

form button {
    background: transparent;
    border: 2px solid #fff;
    color: #fff;
    border-radius: 30px;
    padding: 10px 30px;
    font-size: 15px;
    cursor: pointer;
}

.footer h4 {
    margin-bottom: 25px;
    margin-top: 25px;
    font-weight: 600;
}

.c {
    width: 100%;
    height: 100%;
    display: flex;
    align-items: center;
    flex-direction: column;
}

iframe {
    width: 100%;
    height: 500px;
    filter: invert(90%);
}

/*them2 herro*/

.herro {
    width: 100%;
    min-height: 100vh;
    padding-left: 12%;
    padding-right: 12%;
    box-sizing: border-box;
    text-align: center;
    color: #fff;
}

.row {
    margin-top: 80px;
    display: flex;
    flex-wrap: wrap;
    justify-content: space-around;
}

.col {
    flex-basis: 28%;
    box-sizing: border-box;
    text-align: center;
    position: relative;
    cursor: pointer;
    min-width: 230px;
    margin-bottom: 20px;
}

.profile {
    width: 100%;
    height: 100%;
    box-sizing: border-box;
    background: #1e2648;
    padding: 12px;
}

.profile img {
    width: 100%;
}

.profile h2 {
    margin: 25px 0 10px;
    font-weight: 500;
}

.profile p {
    margin-bottom: 10px;
    color: #89c0e3;
}
</style>
