using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200028A RID: 650
	public class LawData : SaveData
	{
		// Token: 0x0600309F RID: 12447 RVA: 0x0010F074 File Offset: 0x0010D274
		// Note: this type is marked as 'beforefieldinit'.
		static LawData()
		{
			Il2CppClassPointerStore<LawData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LawData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LawData>.NativeClassPtr);
			LawData.NativeFieldInfoPtr_InternalLawIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LawData>.NativeClassPtr, "InternalLawIntensity");
			LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LawData>.NativeClassPtr, 100669014);
		}

		// Token: 0x060030A0 RID: 12448 RVA: 0x0010F0CC File Offset: 0x0010D2CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136658, RefRangeEnd = 136659, XrefRangeStart = 136657, XrefRangeEnd = 136658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LawData(float internalLawIntensity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LawData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref internalLawIntensity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LawData.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060030A1 RID: 12449 RVA: 0x000197C0 File Offset: 0x000179C0
		public LawData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x0010F114 File Offset: 0x0010D314
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x000197C9 File Offset: 0x000179C9
		public unsafe float InternalLawIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LawData.NativeFieldInfoPtr_InternalLawIntensity)) = value;
			}
		}

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeFieldInfoPtr_InternalLawIntensity;

		// Token: 0x04002014 RID: 8212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
