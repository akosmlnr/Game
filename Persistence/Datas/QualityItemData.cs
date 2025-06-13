using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000284 RID: 644
	[Serializable]
	public class QualityItemData : ItemData
	{
		// Token: 0x0600307D RID: 12413 RVA: 0x0010EABC File Offset: 0x0010CCBC
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemData()
		{
			Il2CppClassPointerStore<QualityItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr);
			QualityItemData.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, "Quality");
			QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr, 100669008);
		}

		// Token: 0x0600307E RID: 12414 RVA: 0x0010EB14 File Offset: 0x0010CD14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 136480, RefRangeEnd = 136486, XrefRangeStart = 136480, XrefRangeEnd = 136486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemData(string iD, int quantity, string quality) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(iD);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(quality);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemData.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600307F RID: 12415 RVA: 0x00019671 File Offset: 0x00017871
		public QualityItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FB0 RID: 4016
		// (get) Token: 0x06003080 RID: 12416 RVA: 0x0010EB80 File Offset: 0x0010CD80
		// (set) Token: 0x06003081 RID: 12417 RVA: 0x0001967A File Offset: 0x0001787A
		public unsafe string Quality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemData.NativeFieldInfoPtr_Quality), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeFieldInfoPtr_Quality;

		// Token: 0x04002006 RID: 8198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_String_0;
	}
}
