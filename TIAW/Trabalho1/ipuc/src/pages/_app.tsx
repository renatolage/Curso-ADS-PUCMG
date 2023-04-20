import type { AppProps } from 'next/app'
import '../../node_modules/bulma/css/bulma.css'


export default function App({ Component, pageProps }: AppProps) {
  return <Component {...pageProps} />
}
