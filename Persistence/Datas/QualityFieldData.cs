using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029D RID: 669
	[System.Serializable]
	public class QualityFieldData : Il2CppSystem.Object
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x001105A4 File Offset: 0x0010E7A4
		// Note: this type is marked as 'beforefieldinit'.
		static QualityFieldData()
		{
			Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "QualityFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr);
			QualityFieldData.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, "Value");
			QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr, 100669034);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x001105FC File Offset: 0x0010E7FC
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityFieldData(EQuality value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityFieldData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityFieldData.NativeMethodInfoPtr__ctor_Public_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x00019C9C File Offset: 0x00017E9C
		public QualityFieldData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x00110644 File Offset: 0x0010E844
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x00019CA5 File Offset: 0x00017EA5
		public unsafe EQuality Value
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QualityFieldData.NativeFieldInfoPtr_Value)) = value;
			}
		}

		// Token: 0x0400204A RID: 8266
		private static readonly System.IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x0400204B RID: 8267
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EQuality_0;
	}
}
