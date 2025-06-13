using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Shop
{
	// Token: 0x02000738 RID: 1848
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		// Token: 0x0600A570 RID: 42352 RVA: 0x0029AD40 File Offset: 0x00298F40
		// Note: this type is marked as 'beforefieldinit'.
		static ShopInterfaceDetailPanel()
		{
			Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Shop", "ShopInterfaceDetailPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr);
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "Panel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "LayoutGroup");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "DescriptionLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "UnlockLabel");
			ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "listing");
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683640);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683641);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683642);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683643);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683644);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683645);
			ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, 100683646);
		}

		// Token: 0x0600A571 RID: 42353 RVA: 0x0029AE60 File Offset: 0x00299060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290127, XrefRangeEnd = 290130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A572 RID: 42354 RVA: 0x0029AE94 File Offset: 0x00299094
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 290153, RefRangeEnd = 290155, XrefRangeStart = 290130, XrefRangeEnd = 290153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(ListingUI _listing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_listing);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Open_Public_Void_ListingUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A573 RID: 42355 RVA: 0x0029AED8 File Offset: 0x002990D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290155, XrefRangeEnd = 290156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A574 RID: 42356 RVA: 0x0029AF0C File Offset: 0x0029910C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290166, RefRangeEnd = 290167, XrefRangeStart = 290156, XrefRangeEnd = 290166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Position()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Position_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A575 RID: 42357 RVA: 0x0029AF40 File Offset: 0x00299140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290167, XrefRangeEnd = 290171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A576 RID: 42358 RVA: 0x0029AF74 File Offset: 0x00299174
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopInterfaceDetailPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A577 RID: 42359 RVA: 0x0029AFB0 File Offset: 0x002991B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290171, XrefRangeEnd = 290176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x0005132B File Offset: 0x0004F52B
		public ShopInterfaceDetailPanel(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170032CE RID: 13006
		// (get) Token: 0x0600A579 RID: 42361 RVA: 0x0029AFF0 File Offset: 0x002991F0
		// (set) Token: 0x0600A57A RID: 42362 RVA: 0x00051334 File Offset: 0x0004F534
		public unsafe RectTransform Panel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_Panel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032CF RID: 13007
		// (get) Token: 0x0600A57B RID: 42363 RVA: 0x0029B020 File Offset: 0x00299220
		// (set) Token: 0x0600A57C RID: 42364 RVA: 0x00051353 File Offset: 0x0004F553
		public unsafe VerticalLayoutGroup LayoutGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D0 RID: 13008
		// (get) Token: 0x0600A57D RID: 42365 RVA: 0x0029B050 File Offset: 0x00299250
		// (set) Token: 0x0600A57E RID: 42366 RVA: 0x00051372 File Offset: 0x0004F572
		public unsafe TextMeshProUGUI DescriptionLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_DescriptionLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D1 RID: 13009
		// (get) Token: 0x0600A57F RID: 42367 RVA: 0x0029B080 File Offset: 0x00299280
		// (set) Token: 0x0600A580 RID: 42368 RVA: 0x00051391 File Offset: 0x0004F591
		public unsafe TextMeshProUGUI UnlockLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_UnlockLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170032D2 RID: 13010
		// (get) Token: 0x0600A581 RID: 42369 RVA: 0x0029B0B0 File Offset: 0x002992B0
		// (set) Token: 0x0600A582 RID: 42370 RVA: 0x000513B0 File Offset: 0x0004F5B0
		public unsafe ListingUI listing
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListingUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.NativeFieldInfoPtr_listing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006EFF RID: 28415
		private static readonly System.IntPtr NativeFieldInfoPtr_Panel;

		// Token: 0x04006F00 RID: 28416
		private static readonly System.IntPtr NativeFieldInfoPtr_LayoutGroup;

		// Token: 0x04006F01 RID: 28417
		private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionLabel;

		// Token: 0x04006F02 RID: 28418
		private static readonly System.IntPtr NativeFieldInfoPtr_UnlockLabel;

		// Token: 0x04006F03 RID: 28419
		private static readonly System.IntPtr NativeFieldInfoPtr_listing;

		// Token: 0x04006F04 RID: 28420
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006F05 RID: 28421
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_ListingUI_0;

		// Token: 0x04006F06 RID: 28422
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006F07 RID: 28423
		private static readonly System.IntPtr NativeMethodInfoPtr_Position_Private_Void_0;

		// Token: 0x04006F08 RID: 28424
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006F09 RID: 28425
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F0A RID: 28426
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000C0E RID: 3086
		[ObfuscatedName("ScheduleOne.UI.Shop.ShopInterfaceDetailPanel+<<Open>g__Wait|6_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E2BB RID: 58043 RVA: 0x0035AF08 File Offset: 0x00359108
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique()
			{
				Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShopInterfaceDetailPanel>.NativeClassPtr, "<<Open>g__Wait|6_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>1__state");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>2__current");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, "<>4__this");
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683647);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683648);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683649);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683650);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683651);
				ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr, 100683652);
			}

			// Token: 0x0600E2BC RID: 58044 RVA: 0x0035AFE8 File Offset: 0x003591E8
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2BD RID: 58045 RVA: 0x0035B030 File Offset: 0x00359230
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E2BE RID: 58046 RVA: 0x0035B064 File Offset: 0x00359264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290115, XrefRangeEnd = 290122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170045F3 RID: 17907
			// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x0035B0A0 File Offset: 0x003592A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E2C0 RID: 58048 RVA: 0x0035B0E0 File Offset: 0x003592E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290122, XrefRangeEnd = 290127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170045F4 RID: 17908
			// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x0035B114 File Offset: 0x00359314
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E2C2 RID: 58050 RVA: 0x0006E29D File Offset: 0x0006C49D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045F0 RID: 17904
			// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x0035B154 File Offset: 0x00359354
			// (set) Token: 0x0600E2C4 RID: 58052 RVA: 0x0006E2A6 File Offset: 0x0006C4A6
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045F1 RID: 17905
			// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x0035B17C File Offset: 0x0035937C
			// (set) Token: 0x0600E2C6 RID: 58054 RVA: 0x0006E2C1 File Offset: 0x0006C4C1
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045F2 RID: 17906
			// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x0035B1AC File Offset: 0x003593AC
			// (set) Token: 0x0600E2C8 RID: 58056 RVA: 0x0006E2E0 File Offset: 0x0006C4E0
			public unsafe ShopInterfaceDetailPanel __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShopInterfaceDetailPanel>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ShopInterfaceDetailPanel.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObShObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040097F4 RID: 38900
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040097F5 RID: 38901
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040097F6 RID: 38902
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040097F7 RID: 38903
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040097F8 RID: 38904
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097F9 RID: 38905
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040097FA RID: 38906
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040097FB RID: 38907
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040097FC RID: 38908
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
