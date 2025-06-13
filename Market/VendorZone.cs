using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x020003A0 RID: 928
	public class VendorZone : MonoBehaviour
	{
		// Token: 0x0600476E RID: 18286 RVA: 0x001605F0 File Offset: 0x0015E7F0
		// Note: this type is marked as 'beforefieldinit'.
		static VendorZone()
		{
			Il2CppClassPointerStore<VendorZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "VendorZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendorZone>.NativeClassPtr);
			VendorZone.NativeFieldInfoPtr_zoneCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "zoneCollider");
			VendorZone.NativeFieldInfoPtr_doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "doors");
			VendorZone.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "openTime");
			VendorZone.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "closeTime");
			VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672154);
			VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672155);
			VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672156);
			VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672157);
			VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672158);
			VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100672159);
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x0600476F RID: 18287 RVA: 0x001606E8 File Offset: 0x0015E8E8
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162634, XrefRangeEnd = 162640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06004770 RID: 18288 RVA: 0x00160724 File Offset: 0x0015E924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162640, XrefRangeEnd = 162658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004771 RID: 18289 RVA: 0x00160760 File Offset: 0x0015E960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162658, XrefRangeEnd = 162672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004772 RID: 18290 RVA: 0x00160794 File Offset: 0x0015E994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162672, XrefRangeEnd = 162680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerWithinVendorZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004773 RID: 18291 RVA: 0x001607D0 File Offset: 0x0015E9D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162686, RefRangeEnd = 162687, XrefRangeStart = 162680, XrefRangeEnd = 162686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorsActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004774 RID: 18292 RVA: 0x00160810 File Offset: 0x0015EA10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162687, XrefRangeEnd = 162695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendorZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendorZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x000229CF File Offset: 0x00020BCF
		public VendorZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0016084C File Offset: 0x0015EA4C
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x000229D8 File Offset: 0x00020BD8
		public unsafe BoxCollider zoneCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x0016087C File Offset: 0x0015EA7C
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x000229F7 File Offset: 0x00020BF7
		public unsafe List<GameObject> doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x001608AC File Offset: 0x0015EAAC
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x00022A16 File Offset: 0x00020C16
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600477C RID: 18300 RVA: 0x001608D4 File Offset: 0x0015EAD4
		// (set) Token: 0x0600477D RID: 18301 RVA: 0x00022A31 File Offset: 0x00020C31
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04002FEA RID: 12266
		private static readonly IntPtr NativeFieldInfoPtr_zoneCollider;

		// Token: 0x04002FEB RID: 12267
		private static readonly IntPtr NativeFieldInfoPtr_doors;

		// Token: 0x04002FEC RID: 12268
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002FED RID: 12269
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002FEE RID: 12270
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002FEF RID: 12271
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002FF0 RID: 12272
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Private_Void_0;

		// Token: 0x04002FF1 RID: 12273
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0;

		// Token: 0x04002FF2 RID: 12274
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0;

		// Token: 0x04002FF3 RID: 12275
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
