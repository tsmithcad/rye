import os

def create_music_folder_structure(root_path):
    directories = [
        "Rhyme Engine/Songwriting and Composition/Lyrics",
        "Rhyme Engine/Songwriting and Composition/Song Structures",
        "Rhyme Engine/Songwriting and Composition/Drafts",
        "Rhyme Engine/Songwriting and Composition/Final Versions",
        "Rhyme Engine/Songwriting and Composition/Collaborations",
        "Rhyme Engine/Producers/Beat Libraries/Purchased",
        "Rhyme Engine/Producers/Beat Libraries/Leased",
        "Rhyme Engine/Producers/Beat Libraries/Originals",
        "Rhyme Engine/Producers/Projects",
        "Rhyme Engine/Producers/Invoices & Contracts",
        "Rhyme Engine/Artists / Songwriters/Profiles",
        "Rhyme Engine/Artists / Songwriters/Discographies",
        "Rhyme Engine/Artists / Songwriters/Vocals/Raw",
        "Rhyme Engine/Artists / Songwriters/Vocals/Edited",
        "Rhyme Engine/Artists / Songwriters/Contracts & Agreements",
        "Rhyme Engine/Music Production/Projects",
        "Rhyme Engine/Music Production/Final Tracks",
        "Rhyme Engine/Music Production/Demos",
        "Rhyme Engine/Music Production/Backing Tracks & Instrumentals",
        "Rhyme Engine/Music Production/MIDI Files",
        "Rhyme Engine/Music Production/Plugins & Presets",
        "Rhyme Engine/Recording and Mastering/Sessions",
        "Rhyme Engine/Recording and Mastering/Master Tracks",
        "Rhyme Engine/Recording and Mastering/Studio Bookings & Invoices",
        "Rhyme Engine/Copyright Registration/Submitted",
        "Rhyme Engine/Copyright Registration/Pending",
        "Rhyme Engine/Copyright Registration/Approved",
        "Rhyme Engine/Copyright Registration/Certificates",
        "Rhyme Engine/Music Publishing/Published Works",
        "Rhyme Engine/Music Publishing/Royalty Statements",
        "Rhyme Engine/Music Publishing/Contracts & Agreements",
        "Rhyme Engine/Album Artwork and Packaging/Drafts",
        "Rhyme Engine/Album Artwork and Packaging/Final Versions",
        "Rhyme Engine/Album Artwork and Packaging/Source Files",
        "Rhyme Engine/Album Artwork and Packaging/Print Ready",
        "Rhyme Engine/Music Legal Process/Legal Advisories",
        "Rhyme Engine/Music Legal Process/Case Files",
        "Rhyme Engine/Music Legal Process/Contracts",
        "Rhyme Engine/Music Legal Process/Disputes & Resolutions",
        "Rhyme Engine/Performance Rights Organizations/Registrations",
        "Rhyme Engine/Performance Rights Organizations/Events & Performances",
        "Rhyme Engine/Performance Rights Organizations/Royalty Collections",
        "Rhyme Engine/Audio Distribution and Licensing/Distributed Tracks",
        "Rhyme Engine/Audio Distribution and Licensing/Licensing Agreements",
        "Rhyme Engine/Audio Distribution and Licensing/Platforms & Services",
        "Rhyme Engine/Online Video Distribution/Video Files",
        "Rhyme Engine/Online Video Distribution/Thumbnails & Artworks",
        "Rhyme Engine/Online Video Distribution/Monetization Reports",
        "Rhyme Engine/Social Media Content/Posts & Images",
        "Rhyme Engine/Social Media Content/Campaigns",
        "Rhyme Engine/Social Media Content/Analytics & Insights",
        "Rhyme Engine/Music Events/Upcoming",
        "Rhyme Engine/Music Events/Past Events",
        "Rhyme Engine/Music Events/Tickets & Bookings",
        "Rhyme Engine/Promotions & Marketing/Brand Development",
        "Rhyme Engine/Promotions & Marketing/Logos & Branding",
        "Rhyme Engine/Promotions & Marketing/Merchandise",
        "Rhyme Engine/Promotions & Marketing/Brand Guidelines",
        "Rhyme Engine/Promotions & Marketing/Trademarks",
        "Rhyme Engine/Promotions & Marketing/Marketing",
        "Rhyme Engine/Promotions & Marketing/Campaigns",
        "Rhyme Engine/Promotions & Marketing/Ad Copies & Creatives",
        "Rhyme Engine/Promotions & Marketing/Marketing Reports",
        "Rhyme Engine/Promotions & Marketing/Collaborations & Partnerships"
    ]

    for directory in directories:
        os.makedirs(os.path.join(root_path, directory), exist_ok=True)

# Get the path of the currently executing script
script_path = os.path.dirname(os.path.realpath(__file__))

# Create the folder structure in the same directory as the script
create_music_folder_structure(script_path)
