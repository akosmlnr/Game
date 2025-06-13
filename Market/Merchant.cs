using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200039E RID: 926
	public class Merchant : MonoBehaviour
	{
		// Token: 0x0600475D RID: 18269 RVA: 0x00160354 File Offset: 0x0015E554
		// Note: this type is marked as 'beforefieldinit'.
		static Merchant()
		{
			Il2CppClassPointerStore<Merchant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "Merchant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Merchant>.NativeClassPtr);
			Merchant.NativeFieldInfoPtr_shopName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "shopName");
			Merchant.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "openTime");
			Merchant.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "closeTime");
			Merchant.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Merchant>.NativeClassPtr, "intObj");
			Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100672149);
			Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100672150);
			Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100672151);
			Merchant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Merchant>.NativeClassPtr, 100672152);
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x00160424 File Offset: 0x0015E624
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x00160460 File Offset: 0x0015E660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162622, XrefRangeEnd = 162634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x00160494 File Offset: 0x0015E694
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Merchant.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x001604D0 File Offset: 0x0015E6D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Merchant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Merchant>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Merchant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00022910 File Offset: 0x00020B10
		public Merchant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x06004763 RID: 18275 RVA: 0x0016050C File Offset: 0x0015E70C
		// (set) Token: 0x06004764 RID: 18276 RVA: 0x00022919 File Offset: 0x00020B19
		public unsafe string shopName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_shopName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x06004765 RID: 18277 RVA: 0x00160534 File Offset: 0x0015E734
		// (set) Token: 0x06004766 RID: 18278 RVA: 0x00022938 File Offset: 0x00020B38
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06004767 RID: 18279 RVA: 0x0016055C File Offset: 0x0015E75C
		// (set) Token: 0x06004768 RID: 18280 RVA: 0x00022953 File Offset: 0x00020B53
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06004769 RID: 18281 RVA: 0x00160584 File Offset: 0x0015E784
		// (set) Token: 0x0600476A RID: 18282 RVA: 0x0002296E File Offset: 0x00020B6E
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Merchant.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeFieldInfoPtr_shopName;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002FE4 RID: 12260
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x04002FE5 RID: 12261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002FE6 RID: 12262
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04002FE7 RID: 12263
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04002FE8 RID: 12264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
