using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022E RID: 558
	public class SaveInfo : Il2CppSystem.Object
	{
		// Token: 0x06002DF6 RID: 11766 RVA: 0x00105848 File Offset: 0x00103A48
		// Note: this type is marked as 'beforefieldinit'.
		static SaveInfo()
		{
			Il2CppClassPointerStore<SaveInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "SaveInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr);
			SaveInfo.NativeFieldInfoPtr_SavePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SavePath");
			SaveInfo.NativeFieldInfoPtr_SaveSlotNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveSlotNumber");
			SaveInfo.NativeFieldInfoPtr_OrganisationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "OrganisationName");
			SaveInfo.NativeFieldInfoPtr_DateCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateCreated");
			SaveInfo.NativeFieldInfoPtr_DateLastPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "DateLastPlayed");
			SaveInfo.NativeFieldInfoPtr_Networth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "Networth");
			SaveInfo.NativeFieldInfoPtr_SaveVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "SaveVersion");
			SaveInfo.NativeFieldInfoPtr_MetaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, "MetaData");
			SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr, 100668607);
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0010592C File Offset: 0x00103B2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130247, RefRangeEnd = 130249, XrefRangeStart = 130242, XrefRangeEnd = 130247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveInfo(string savePath, int saveSlotNumber, string organisationName, Il2CppSystem.DateTime dateCreated, Il2CppSystem.DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveInfo>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)8) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(savePath);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref saveSlotNumber;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(organisationName);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref dateCreated;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref dateLastPlayed;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref networth;
			ptr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(saveVersion);
			ptr[checked(unchecked((System.UIntPtr)7) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveInfo.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x00018924 File Offset: 0x00016B24
		public SaveInfo(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x001059E8 File Offset: 0x00103BE8
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0001892D File Offset: 0x00016B2D
		public unsafe string SavePath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SavePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x00105A10 File Offset: 0x00103C10
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x0001894C File Offset: 0x00016B4C
		public unsafe int SaveSlotNumber
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveSlotNumber)) = value;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00105A38 File Offset: 0x00103C38
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00018967 File Offset: 0x00016B67
		public unsafe string OrganisationName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_OrganisationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00105A60 File Offset: 0x00103C60
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00018986 File Offset: 0x00016B86
		public unsafe Il2CppSystem.DateTime DateCreated
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateCreated)) = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00105A88 File Offset: 0x00103C88
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x000189A1 File Offset: 0x00016BA1
		public unsafe Il2CppSystem.DateTime DateLastPlayed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_DateLastPlayed)) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x00105AB0 File Offset: 0x00103CB0
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x000189BC File Offset: 0x00016BBC
		public unsafe float Networth
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_Networth)) = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x00105AD8 File Offset: 0x00103CD8
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x000189D7 File Offset: 0x00016BD7
		public unsafe string SaveVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_SaveVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00105B00 File Offset: 0x00103D00
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x000189F6 File Offset: 0x00016BF6
		public unsafe MetaData MetaData
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MetaData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveInfo.NativeFieldInfoPtr_MetaData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E83 RID: 7811
		private static readonly System.IntPtr NativeFieldInfoPtr_SavePath;

		// Token: 0x04001E84 RID: 7812
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveSlotNumber;

		// Token: 0x04001E85 RID: 7813
		private static readonly System.IntPtr NativeFieldInfoPtr_OrganisationName;

		// Token: 0x04001E86 RID: 7814
		private static readonly System.IntPtr NativeFieldInfoPtr_DateCreated;

		// Token: 0x04001E87 RID: 7815
		private static readonly System.IntPtr NativeFieldInfoPtr_DateLastPlayed;

		// Token: 0x04001E88 RID: 7816
		private static readonly System.IntPtr NativeFieldInfoPtr_Networth;

		// Token: 0x04001E89 RID: 7817
		private static readonly System.IntPtr NativeFieldInfoPtr_SaveVersion;

		// Token: 0x04001E8A RID: 7818
		private static readonly System.IntPtr NativeFieldInfoPtr_MetaData;

		// Token: 0x04001E8B RID: 7819
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_DateTime_DateTime_Single_String_MetaData_0;
	}
}
