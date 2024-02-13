# dice

<https://i574n.github.io/dice>

[![깃허브 코드스페이스](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=756477988)

---

- [Updates](#updates)
  - [2024-02-08](#2024-02-08)
    - [The Challenge of State Management](#the-challenge-of-state-management)
    - [Transition to IndexedDB for Caching](#transition-to-indexeddb-for-caching)
    - [Performance Considerations](#performance-considerations)
    - [Rust's Type System and Ownership Model](#rusts-type-system-and-ownership-model)
      - [Signal Management Complexity](#signal-management-complexity)
    - [Asynchronous Operations and State](#asynchronous-operations-and-state)
    - [Bridging Conceptual Models](#bridging-conceptual-models)
    - [Rust and Spiral](#rust-and-spiral)
    - [UI Evolution](#ui-evolution)
    - [Lessons Learned and Path Forward](#lessons-learned-and-path-forward)
- [Links](#links)
  - [Code and Documentation](#code-and-documentation)

## Updates

### 2024-02-08

Over the recent weeks, the development of the UI component of our repository has presented a multifaceted set of challenges, underscoring the intricate dance between advancing functionality, ensuring performance, and maintaining codebase integrity in the face of evolving requirements. This detailed assessment aims to shed light on the hurdles encountered, the methodologies employed to surmount them, and the lessons distilled from this endeavor.

#### The Challenge of State Management

At the heart of our UI development journey has been the sophisticated challenge of state management, particularly the integration and efficient handling of reactive state within the Leptos framework. The ambition to create a responsive, intuitive user interface necessitated a robust state management solution that could handle complex dependencies and asynchronous operations without sacrificing the reactivity or performance of the application.

The initial approach, leveraging a `HashMap` for caching with signals, aimed to optimize data retrieval and minimize unnecessary database interactions. However, this strategy introduced complexity, particularly in managing the lifecycle of reactive signals and ensuring data consistency across the application. The intricacies of signal management within Leptos—especially around nested updates and signal disposal—exposed potential pitfalls that could lead to inefficient update chains or, worse, application instability.

#### Transition to IndexedDB for Caching

In pursuit of a more scalable and maintainable approach, we pivoted to leveraging IndexedDB directly, treating each URL's data as an individual key for storage and retrieval. This method promised granular control over data management and the potential for improved performance on individual reads/writes. Yet, this transition was not without its trade-offs. The move towards a more decentralized caching mechanism necessitated a reevaluation of our data consistency strategies and introduced additional complexity in handling bulk operations and ensuring the freshness of the data served to the user.

#### Performance Considerations

A primary consideration throughout the UI development process has been performance. Each architectural decision, from the choice of caching mechanism to the structuring of reactive state, was evaluated not only on its immediate implications for development simplicity but also for its long-term impact on application responsiveness and efficiency. The challenge lay in balancing the desire for a dynamic, highly interactive user interface with the need to minimize latency, manage memory effectively, and ensure a seamless user experience across a wide range of devices and network conditions.

#### Rust's Type System and Ownership Model

Rust's type system and ownership model, designed to ensure memory safety and concurrency without a garbage collector, require that each value in Rust has a single owner and that at any given time, you can either have mutable or immutable references to a value, but not both. This model, while effective for preventing data races and memory leaks, introduces complexity when applied to reactive UI state management, where a piece of state may need to be accessed or updated from multiple points in the application.

##### Signal Management Complexity

Signals in UI development are used to represent reactive state—values that can change over time, with the UI automatically updating in response to these changes. Implementing this pattern in Rust involves managing lifetimes and mutability in a way that aligns with Rust's strict rules, which is non-trivial:

- **Mutable Access**: Signals often need to be mutable so that they can be updated in response to user interactions or asynchronous operations. Rust's borrow checker ensures that only one mutable reference exists at a time, complicating scenarios where multiple components or functions need to update the state.
- **Ownership and Lifetimes**: Signals representing UI state must live long enough to be accessible throughout the component lifecycle, requiring careful management of lifetimes and ownership, especially in dynamic UIs where components can be created and destroyed in response to user actions.

#### Asynchronous Operations and State

Modern UIs heavily rely on asynchronous operations—fetching data from a server, performing expensive computations in the background, etc. Integrating these operations with a reactive state in Rust involves dealing with futures and the borrow checker:

- **Concurrency and Safety**: Rust's safety guarantees extend to asynchronous code, requiring that access to shared state across async boundaries be managed to prevent data races. This often necessitates additional synchronization primitives (e.g., mutexes), complicating state management.
- **Lifetime of Async Data**: When data from asynchronous operations is bound to UI state, ensuring that the data's lifetime matches the UI components' lifecycle while satisfying Rust's lifetime requirements adds another layer of complexity.

#### Bridging Conceptual Models

The reactive programming model prevalent in UI development, characterized by dynamic state changes and automatic UI updates, contrasts with Rust's model, which emphasizes explicit state changes and manual UI redraws. Bridging these models requires a careful architectural design:

- **Event Handling and State Updates**: Implementing an efficient and error-free event handling mechanism that translates user interactions into state updates according to Rust's rules.
- **State Propagation**: Ensuring that changes to the state are efficiently propagated to the UI, triggering redraws where necessary, while minimizing unnecessary computations or updates.

#### Rust and Spiral

While compiling to Rust via Spiral brings the advantages of Rust's robust type system and ownership model to UI development, integrating these features with reactive state management and signals introduces inherent complexities. Managing mutable shared state, lifetimes, and asynchronous operations within Rust's strict safety constraints demands a deep understanding of both Rust's model and reactive programming principles. Addressing these challenges requires innovative solutions that bridge the conceptual gap between the reactive state in UIs and Rust's compile-time guarantees, ensuring both efficient application performance and developer ergonomics.

#### UI Evolution

Transitioning through the epochs of web development, from the era of PHP and jQuery to the modern landscape dominated by sophisticated client-side frameworks and advanced programming languages, encapsulates a journey of adaptation and evolution. PHP and jQuery, hallmarks of earlier web development phases, provided robust server-side processing and streamlined client-side scripting, respectively. These technologies laid the groundwork for web development, emphasizing simplicity in execution and a direct approach to handling HTTP requests, DOM manipulation, and event management.

The contemporary shift towards complex frameworks, reactive programming, and languages with strict type systems and ownership models, such as Rust, represents a paradigmatic shift. This transition is not merely a change in tools or languages but a fundamental rethinking of web application architecture—from monolithic pages to dynamic, component-driven single-page applications. It introduces a landscape where state management, real-time data synchronization, and modular development are paramount.

This evolution, while offering enhanced capabilities for creating rich, interactive user interfaces and efficient back-end services, also demands a broader skill set and a deeper understanding of both theoretical concepts and practical implementations. The emphasis on type safety, concurrency, and reactive state across both the client and server sides challenges developers to integrate disparate systems into cohesive, scalable applications.

For developers rooted in the traditional, the modern web development ecosystem offers both challenges and opportunities for growth. It invites a synthesis of established practices with emerging paradigms, fostering an environment where innovation is continuous, and learning is ongoing. In this context, the journey of web development is seen not as a series of obsolescences but as an expanding continuum where each phase contributes to the richness and complexity of the field.

#### Lessons Learned and Path Forward

This journey through the development of the UI component has been rich with lessons on the complexities of modern web development. It underscored the importance of clear state management patterns, the necessity of balancing innovation with practicality, and the value of continuous assessment and adaptation of our approaches in response to emerging challenges.

As we move forward, the experiences garnered from this phase of development will serve as a beacon, guiding future architectural and design decisions. The insights gained from grappling with state management complexities, performance optimization, and the intricacies of working with advanced web technologies will inform our continued efforts to refine and enhance the user interface.

In conclusion, the development of the UI component, while challenging, has been an invaluable crucible for innovation and learning. It has pushed the boundaries of our technical expertise, challenged our preconceptions, and ultimately led to a more sophisticated, resilient application architecture. As we continue to iterate and evolve our approach, we remain committed to delivering a user interface that is not only performant and feature-rich but also a joy to use.

This assessment, while highlighting the hurdles we've faced, also stands as a testament to the progress we've made and the unwavering dedication of our team to excellence. We look forward to sharing our continued journey with the community on GitHub and beyond.

---

## Links

### Code and Documentation

- Repository File Tree
<https://i574n.github.io/dice/index.html>

- Smart Contract Dice Rolls History (Rust WASM frontend, display of on-chain data using NEAR Protocol queried from their Public API)
<https://i574n.github.io/dice/ui/dist>

- Dice Core Code
<https://i574n.github.io/dice/lib/dice.dib.html>
