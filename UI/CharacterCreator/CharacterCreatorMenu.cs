using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x02000727 RID: 1831
	public class CharacterCreatorMenu : MonoBehaviour
	{
		// Token: 0x0600A356 RID: 41814 RVA: 0x00293E6C File Offset: 0x0029206C
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorMenu()
		{
			Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr);
			CharacterCreatorMenu.NativeFieldInfoPtr_Windows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Windows");
			CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "CategoryLabel");
			CharacterCreatorMenu.NativeFieldInfoPtr_BackButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "BackButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_NextButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "NextButton");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindowIndex");
			CharacterCreatorMenu.NativeFieldInfoPtr_openWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "openWindow");
			CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100683369);
			CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100683370);
			CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100683371);
			CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100683372);
			CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, 100683373);
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x00293F78 File Offset: 0x00292178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287241, XrefRangeEnd = 287247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x00293FAC File Offset: 0x002921AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 287256, RefRangeEnd = 287259, XrefRangeStart = 287247, XrefRangeEnd = 287256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenWindow(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x00293FEC File Offset: 0x002921EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287259, XrefRangeEnd = 287260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x00294020 File Offset: 0x00292220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287260, XrefRangeEnd = 287261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x00294054 File Offset: 0x00292254
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x000501B5 File Offset: 0x0004E3B5
		public CharacterCreatorMenu(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600A35D RID: 41821 RVA: 0x00294090 File Offset: 0x00292290
		// (set) Token: 0x0600A35E RID: 41822 RVA: 0x000501BE File Offset: 0x0004E3BE
		public unsafe Il2CppReferenceArray<CharacterCreatorMenu.Window> Windows
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CharacterCreatorMenu.Window>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_Windows), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600A35F RID: 41823 RVA: 0x002940C0 File Offset: 0x002922C0
		// (set) Token: 0x0600A360 RID: 41824 RVA: 0x000501DD File Offset: 0x0004E3DD
		public unsafe TextMeshProUGUI CategoryLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_CategoryLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A361 RID: 41825 RVA: 0x002940F0 File Offset: 0x002922F0
		// (set) Token: 0x0600A362 RID: 41826 RVA: 0x000501FC File Offset: 0x0004E3FC
		public unsafe Button BackButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_BackButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600A363 RID: 41827 RVA: 0x00294120 File Offset: 0x00292320
		// (set) Token: 0x0600A364 RID: 41828 RVA: 0x0005021B File Offset: 0x0004E41B
		public unsafe Button NextButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_NextButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003227 RID: 12839
		// (get) Token: 0x0600A365 RID: 41829 RVA: 0x00294150 File Offset: 0x00292350
		// (set) Token: 0x0600A366 RID: 41830 RVA: 0x0005023A File Offset: 0x0004E43A
		public unsafe int openWindowIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindowIndex)) = value;
			}
		}

		// Token: 0x17003228 RID: 12840
		// (get) Token: 0x0600A367 RID: 41831 RVA: 0x00294178 File Offset: 0x00292378
		// (set) Token: 0x0600A368 RID: 41832 RVA: 0x00050255 File Offset: 0x0004E455
		public unsafe CharacterCreatorMenu.Window openWindow
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreatorMenu.Window>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.NativeFieldInfoPtr_openWindow), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D83 RID: 28035
		private static readonly System.IntPtr NativeFieldInfoPtr_Windows;

		// Token: 0x04006D84 RID: 28036
		private static readonly System.IntPtr NativeFieldInfoPtr_CategoryLabel;

		// Token: 0x04006D85 RID: 28037
		private static readonly System.IntPtr NativeFieldInfoPtr_BackButton;

		// Token: 0x04006D86 RID: 28038
		private static readonly System.IntPtr NativeFieldInfoPtr_NextButton;

		// Token: 0x04006D87 RID: 28039
		private static readonly System.IntPtr NativeFieldInfoPtr_openWindowIndex;

		// Token: 0x04006D88 RID: 28040
		private static readonly System.IntPtr NativeFieldInfoPtr_openWindow;

		// Token: 0x04006D89 RID: 28041
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006D8A RID: 28042
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenWindow_Public_Void_Int32_0;

		// Token: 0x04006D8B RID: 28043
		private static readonly System.IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x04006D8C RID: 28044
		private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x04006D8D RID: 28045
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFD RID: 3069
		[System.Serializable]
		public class Window : Il2CppSystem.Object
		{
			// Token: 0x0600E224 RID: 57892 RVA: 0x00359484 File Offset: 0x00357684
			// Note: this type is marked as 'beforefieldinit'.
			static Window()
			{
				Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterCreatorMenu>.NativeClassPtr, "Window");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr);
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Name");
				CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, "Container");
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100683374);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100683375);
				CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr, 100683376);
			}

			// Token: 0x0600E225 RID: 57893 RVA: 0x00359514 File Offset: 0x00357714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287235, XrefRangeEnd = 287238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Open()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E226 RID: 57894 RVA: 0x00359548 File Offset: 0x00357748
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287238, XrefRangeEnd = 287241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E227 RID: 57895 RVA: 0x0035957C File Offset: 0x0035777C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Window() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorMenu.Window>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorMenu.Window.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E228 RID: 57896 RVA: 0x0006DDF2 File Offset: 0x0006BFF2
			public Window(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C7 RID: 17863
			// (get) Token: 0x0600E229 RID: 57897 RVA: 0x003595B8 File Offset: 0x003577B8
			// (set) Token: 0x0600E22A RID: 57898 RVA: 0x0006DDFB File Offset: 0x0006BFFB
			public unsafe string Name
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170045C8 RID: 17864
			// (get) Token: 0x0600E22B RID: 57899 RVA: 0x003595E0 File Offset: 0x003577E0
			// (set) Token: 0x0600E22C RID: 57900 RVA: 0x0006DE1A File Offset: 0x0006C01A
			public unsafe RectTransform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorMenu.Window.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400979D RID: 38813
			private static readonly System.IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x0400979E RID: 38814
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x0400979F RID: 38815
			private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

			// Token: 0x040097A0 RID: 38816
			private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

			// Token: 0x040097A1 RID: 38817
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
