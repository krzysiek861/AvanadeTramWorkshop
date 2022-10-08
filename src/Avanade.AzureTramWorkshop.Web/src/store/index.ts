import { createStore } from 'vuex'
import memeModule from './meme.module'
import otherModule from './other.module'
import parametersModule from './parameters.module'
import speedModule from './speed.module'
import temperatureModule from './temperature.module'

export default createStore({
  modules: {
    meme: memeModule,
    other: otherModule,
    parameters: parametersModule,
    speed: speedModule,
    temperature: temperatureModule,
  }
})