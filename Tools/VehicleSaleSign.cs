using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000575 RID: 1397
	public class VehicleSaleSign : MonoBehaviour
	{
		// Token: 0x06007A1C RID: 31260 RVA: 0x00212A10 File Offset: 0x00210C10
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleSaleSign()
		{
			Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VehicleSaleSign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr);
			VehicleSaleSign.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "NameLabel");
			VehicleSaleSign.NativeFieldInfoPtr_PriceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, "PriceLabel");
			VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678745);
			VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr, 100678746);
		}

		// Token: 0x06007A1D RID: 31261 RVA: 0x00212A90 File Offset: 0x00210C90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236029, XrefRangeEnd = 236037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A1E RID: 31262 RVA: 0x00212AC4 File Offset: 0x00210CC4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleSaleSign() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleSaleSign>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleSaleSign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x000399F7 File Offset: 0x00037BF7
		public VehicleSaleSign(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024B4 RID: 9396
		// (get) Token: 0x06007A20 RID: 31264 RVA: 0x00212B00 File Offset: 0x00210D00
		// (set) Token: 0x06007A21 RID: 31265 RVA: 0x00039A00 File Offset: 0x00037C00
		public unsafe TextMeshPro NameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170024B5 RID: 9397
		// (get) Token: 0x06007A22 RID: 31266 RVA: 0x00212B30 File Offset: 0x00210D30
		// (set) Token: 0x06007A23 RID: 31267 RVA: 0x00039A1F File Offset: 0x00037C1F
		public unsafe TextMeshPro PriceLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleSaleSign.NativeFieldInfoPtr_PriceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005345 RID: 21317
		private static readonly IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x04005346 RID: 21318
		private static readonly IntPtr NativeFieldInfoPtr_PriceLabel;

		// Token: 0x04005347 RID: 21319
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005348 RID: 21320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
