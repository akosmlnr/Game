using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x0200070E RID: 1806
	public class MainMenuPopup : Singleton<MainMenuPopup>
	{
		// Token: 0x0600A0EF RID: 41199 RVA: 0x0028CA64 File Offset: 0x0028AC64
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuPopup()
		{
			Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr);
			MainMenuPopup.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Screen");
			MainMenuPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Title");
			MainMenuPopup.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Description");
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100683136);
			MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100683137);
			MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, 100683138);
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x0028CB0C File Offset: 0x0028AD0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284551, RefRangeEnd = 284552, XrefRangeStart = 284549, XrefRangeEnd = 284551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(MainMenuPopup.Data data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x0028CB50 File Offset: 0x0028AD50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284554, RefRangeEnd = 284555, XrefRangeStart = 284552, XrefRangeEnd = 284554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string title, string description, bool isBad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref isBad;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x0028CBB4 File Offset: 0x0028ADB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284555, XrefRangeEnd = 284558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x0004EB78 File Offset: 0x0004CD78
		public MainMenuPopup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600A0F4 RID: 41204 RVA: 0x0028CBF0 File Offset: 0x0028ADF0
		// (set) Token: 0x0600A0F5 RID: 41205 RVA: 0x0004EB81 File Offset: 0x0004CD81
		public unsafe MainMenuScreen Screen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Screen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600A0F6 RID: 41206 RVA: 0x0028CC20 File Offset: 0x0028AE20
		// (set) Token: 0x0600A0F7 RID: 41207 RVA: 0x0004EBA0 File Offset: 0x0004CDA0
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600A0F8 RID: 41208 RVA: 0x0028CC50 File Offset: 0x0028AE50
		// (set) Token: 0x0600A0F9 RID: 41209 RVA: 0x0004EBBF File Offset: 0x0004CDBF
		public unsafe TextMeshProUGUI Description
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.NativeFieldInfoPtr_Description), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006C09 RID: 27657
		private static readonly System.IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04006C0A RID: 27658
		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04006C0B RID: 27659
		private static readonly System.IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04006C0C RID: 27660
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_Data_0;

		// Token: 0x04006C0D RID: 27661
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_Boolean_0;

		// Token: 0x04006C0E RID: 27662
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BED RID: 3053
		public class Data : Il2CppSystem.Object
		{
			// Token: 0x0600E1A2 RID: 57762 RVA: 0x00357EAC File Offset: 0x003560AC
			// Note: this type is marked as 'beforefieldinit'.
			static Data()
			{
				Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuPopup>.NativeClassPtr, "Data");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr);
				MainMenuPopup.Data.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Title");
				MainMenuPopup.Data.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "Description");
				MainMenuPopup.Data.NativeFieldInfoPtr_IsBad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, "IsBad");
				MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr, 100683139);
			}

			// Token: 0x0600E1A3 RID: 57763 RVA: 0x00357F28 File Offset: 0x00356128
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284548, RefRangeEnd = 284549, XrefRangeStart = 284545, XrefRangeEnd = 284548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Data(string title, string description, bool isBad) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPopup.Data>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref isBad;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPopup.Data.NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1A4 RID: 57764 RVA: 0x0006D95E File Offset: 0x0006BB5E
			public Data(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700459D RID: 17821
			// (get) Token: 0x0600E1A5 RID: 57765 RVA: 0x00357F94 File Offset: 0x00356194
			// (set) Token: 0x0600E1A6 RID: 57766 RVA: 0x0006D967 File Offset: 0x0006BB67
			public unsafe string Title
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700459E RID: 17822
			// (get) Token: 0x0600E1A7 RID: 57767 RVA: 0x00357FBC File Offset: 0x003561BC
			// (set) Token: 0x0600E1A8 RID: 57768 RVA: 0x0006D986 File Offset: 0x0006BB86
			public unsafe string Description
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700459F RID: 17823
			// (get) Token: 0x0600E1A9 RID: 57769 RVA: 0x00357FE4 File Offset: 0x003561E4
			// (set) Token: 0x0600E1AA RID: 57770 RVA: 0x0006D9A5 File Offset: 0x0006BBA5
			public unsafe bool IsBad
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPopup.Data.NativeFieldInfoPtr_IsBad)) = value;
				}
			}

			// Token: 0x04009749 RID: 38729
			private static readonly System.IntPtr NativeFieldInfoPtr_Title;

			// Token: 0x0400974A RID: 38730
			private static readonly System.IntPtr NativeFieldInfoPtr_Description;

			// Token: 0x0400974B RID: 38731
			private static readonly System.IntPtr NativeFieldInfoPtr_IsBad;

			// Token: 0x0400974C RID: 38732
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Boolean_0;
		}
	}
}
