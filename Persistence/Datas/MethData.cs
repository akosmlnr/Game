using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000282 RID: 642
	[Serializable]
	public class MethData : ProductItemData
	{
		// Token: 0x06003075 RID: 12405 RVA: 0x00019607 File Offset: 0x00017807
		// Note: this type is marked as 'beforefieldinit'.
		static MethData()
		{
			Il2CppClassPointerStore<MethData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MethData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethData>.NativeClassPtr);
			MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethData>.NativeClassPtr, 100669006);
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0010E93C File Offset: 0x0010CB3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136642, RefRangeEnd = 136646, XrefRangeStart = 136642, XrefRangeEnd = 136646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethData(string iD, int quantity, string quality, string packagingID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x00019640 File Offset: 0x00017840
		public MethData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_String_0;
	}
}
