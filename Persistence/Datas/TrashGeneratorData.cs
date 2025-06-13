using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002D9 RID: 729
	[Serializable]
	public class TrashGeneratorData : SaveData
	{
		// Token: 0x06003345 RID: 13125 RVA: 0x001168DC File Offset: 0x00114ADC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGeneratorData()
		{
			Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "TrashGeneratorData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr);
			TrashGeneratorData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GUID");
			TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, "GeneratedItems");
			TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr, 100669102);
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00116948 File Offset: 0x00114B48
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 136250, RefRangeEnd = 136261, XrefRangeStart = 136250, XrefRangeEnd = 136261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGeneratorData(string guid, Il2CppStringArray generatedItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGeneratorData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generatedItems);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x0001B3A2 File Offset: 0x000195A2
		public TrashGeneratorData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001091 RID: 4241
		// (get) Token: 0x06003348 RID: 13128 RVA: 0x001169A8 File Offset: 0x00114BA8
		// (set) Token: 0x06003349 RID: 13129 RVA: 0x0001B3AB File Offset: 0x000195AB
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001092 RID: 4242
		// (get) Token: 0x0600334A RID: 13130 RVA: 0x001169D0 File Offset: 0x00114BD0
		// (set) Token: 0x0600334B RID: 13131 RVA: 0x0001B3CA File Offset: 0x000195CA
		public unsafe Il2CppStringArray GeneratedItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGeneratorData.NativeFieldInfoPtr_GeneratedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002143 RID: 8515
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002144 RID: 8516
		private static readonly IntPtr NativeFieldInfoPtr_GeneratedItems;

		// Token: 0x04002145 RID: 8517
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppStringArray_0;
	}
}
