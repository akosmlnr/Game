using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D0 RID: 720
	[System.Serializable]
	public class SaveData : Il2CppSystem.Object
	{
		// Token: 0x060032FB RID: 13051 RVA: 0x00115CCC File Offset: 0x00113ECC
		// Note: this type is marked as 'beforefieldinit'.
		static SaveData()
		{
			Il2CppClassPointerStore<SaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveData>.NativeClassPtr);
			SaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataType");
			SaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "DataVersion");
			SaveData.NativeFieldInfoPtr_GameVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveData>.NativeClassPtr, "GameVersion");
			SaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669088);
			SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669089);
			SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveData>.NativeClassPtr, 100669090);
		}

		// Token: 0x060032FC RID: 13052 RVA: 0x00115D74 File Offset: 0x00113F74
		[CallerCount(109)]
		[CachedScanResults(RefRangeStart = 137093, RefRangeEnd = 137202, XrefRangeStart = 137079, XrefRangeEnd = 137093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00115DB0 File Offset: 0x00113FB0
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetDataVersion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x00115DF8 File Offset: 0x00113FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137202, XrefRangeEnd = 137214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetJson(bool prettyPrint = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref prettyPrint;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveData.NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x0001B0CB File Offset: 0x000192CB
		public SaveData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00115E48 File Offset: 0x00114048
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x0001B0D4 File Offset: 0x000192D4
		public unsafe string DataType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00115E70 File Offset: 0x00114070
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x0001B0F3 File Offset: 0x000192F3
		public unsafe int DataVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00115E98 File Offset: 0x00114098
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x0001B10E File Offset: 0x0001930E
		public unsafe string GameVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SaveData.NativeFieldInfoPtr_GameVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002120 RID: 8480
		private static readonly System.IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002121 RID: 8481
		private static readonly System.IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x04002122 RID: 8482
		private static readonly System.IntPtr NativeFieldInfoPtr_GameVersion;

		// Token: 0x04002123 RID: 8483
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002124 RID: 8484
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDataVersion_Protected_Virtual_New_Int32_0;

		// Token: 0x04002125 RID: 8485
		private static readonly System.IntPtr NativeMethodInfoPtr_GetJson_Public_Virtual_New_String_Boolean_0;
	}
}
