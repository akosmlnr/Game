using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D1 RID: 721
	[System.Serializable]
	public class SerializedSaveData : Il2CppSystem.Object
	{
		// Token: 0x06003306 RID: 13062 RVA: 0x00115EC0 File Offset: 0x001140C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedSaveData()
		{
			Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SerializedSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr);
			SerializedSaveData.NativeFieldInfoPtr__DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataType");
			SerializedSaveData.NativeFieldInfoPtr_DataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataType");
			SerializedSaveData.NativeFieldInfoPtr__DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "_DataVersion");
			SerializedSaveData.NativeFieldInfoPtr_DataVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, "DataVersion");
			SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100669091);
			SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr, 100669092);
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06003307 RID: 13063 RVA: 0x00115F68 File Offset: 0x00114168
		public unsafe string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137214, XrefRangeEnd = 137218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr_get_Version_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00115FA0 File Offset: 0x001141A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137218, XrefRangeEnd = 137223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedSaveData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedSaveData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedSaveData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x0001B12D File Offset: 0x0001932D
		public SerializedSaveData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x00115FDC File Offset: 0x001141DC
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x0001B136 File Offset: 0x00019336
		public unsafe static string _DataType
		{
			get
			{
				System.IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataType, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x00115FFC File Offset: 0x001141FC
		// (set) Token: 0x0600330D RID: 13069 RVA: 0x0001B148 File Offset: 0x00019348
		public unsafe string DataType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x00116024 File Offset: 0x00114224
		// (set) Token: 0x0600330F RID: 13071 RVA: 0x0001B167 File Offset: 0x00019367
		public unsafe static int _DataVersion
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializedSaveData.NativeFieldInfoPtr__DataVersion, (void*)(&value));
			}
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x00116040 File Offset: 0x00114240
		// (set) Token: 0x06003311 RID: 13073 RVA: 0x0001B175 File Offset: 0x00019375
		public unsafe int DataVersion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedSaveData.NativeFieldInfoPtr_DataVersion)) = value;
			}
		}

		// Token: 0x04002126 RID: 8486
		private static readonly System.IntPtr NativeFieldInfoPtr__DataType;

		// Token: 0x04002127 RID: 8487
		private static readonly System.IntPtr NativeFieldInfoPtr_DataType;

		// Token: 0x04002128 RID: 8488
		private static readonly System.IntPtr NativeFieldInfoPtr__DataVersion;

		// Token: 0x04002129 RID: 8489
		private static readonly System.IntPtr NativeFieldInfoPtr_DataVersion;

		// Token: 0x0400212A RID: 8490
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Version_Public_get_String_0;

		// Token: 0x0400212B RID: 8491
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
