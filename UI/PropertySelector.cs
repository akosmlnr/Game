using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000686 RID: 1670
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x0600941D RID: 37917 RVA: 0x00266150 File Offset: 0x00264350
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySelector()
		{
			Il2CppClassPointerStore<PropertySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr);
			PropertySelector.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "container");
			PropertySelector.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonContainer");
			PropertySelector.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonPrefab");
			PropertySelector.NativeFieldInfoPtr_pCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "pCallback");
			PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681748);
			PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681749);
			PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681750);
			PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681751);
			PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681752);
			PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681753);
			PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681754);
			PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681755);
			PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681756);
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x0600941E RID: 37918 RVA: 0x00266284 File Offset: 0x00264484
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 267566, RefRangeEnd = 267567, XrefRangeStart = 267564, XrefRangeEnd = 267566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600941F RID: 37919 RVA: 0x002662C0 File Offset: 0x002644C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267567, XrefRangeEnd = 267589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009420 RID: 37920 RVA: 0x002662FC File Offset: 0x002644FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267589, XrefRangeEnd = 267598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009421 RID: 37921 RVA: 0x00266338 File Offset: 0x00264538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267598, XrefRangeEnd = 267601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009422 RID: 37922 RVA: 0x00266388 File Offset: 0x00264588
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 267632, RefRangeEnd = 267633, XrefRangeStart = 267601, XrefRangeEnd = 267632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSelector(PropertySelector.PropertySelected p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009423 RID: 37923 RVA: 0x002663CC File Offset: 0x002645CC
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009424 RID: 37924 RVA: 0x00266410 File Offset: 0x00264610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 267633, XrefRangeEnd = 267635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProperty(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009425 RID: 37925 RVA: 0x00266454 File Offset: 0x00264654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 267664, RefRangeEnd = 267666, XrefRangeStart = 267635, XrefRangeEnd = 267664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reenableShit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref reenableShit;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009426 RID: 37926 RVA: 0x00266494 File Offset: 0x00264694
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009427 RID: 37927 RVA: 0x000475D0 File Offset: 0x000457D0
		public PropertySelector(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06009428 RID: 37928 RVA: 0x002664D0 File Offset: 0x002646D0
		// (set) Token: 0x06009429 RID: 37929 RVA: 0x000475D9 File Offset: 0x000457D9
		public unsafe GameObject container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x0600942A RID: 37930 RVA: 0x00266500 File Offset: 0x00264700
		// (set) Token: 0x0600942B RID: 37931 RVA: 0x000475F8 File Offset: 0x000457F8
		public unsafe RectTransform buttonContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2E RID: 11566
		// (get) Token: 0x0600942C RID: 37932 RVA: 0x00266530 File Offset: 0x00264730
		// (set) Token: 0x0600942D RID: 37933 RVA: 0x00047617 File Offset: 0x00045817
		public unsafe GameObject buttonPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D2F RID: 11567
		// (get) Token: 0x0600942E RID: 37934 RVA: 0x00266560 File Offset: 0x00264760
		// (set) Token: 0x0600942F RID: 37935 RVA: 0x00047636 File Offset: 0x00045836
		public unsafe PropertySelector.PropertySelected pCallback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector.PropertySelected>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400641C RID: 25628
		private static readonly System.IntPtr NativeFieldInfoPtr_container;

		// Token: 0x0400641D RID: 25629
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x0400641E RID: 25630
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x0400641F RID: 25631
		private static readonly System.IntPtr NativeFieldInfoPtr_pCallback;

		// Token: 0x04006420 RID: 25632
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006421 RID: 25633
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006422 RID: 25634
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006423 RID: 25635
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006424 RID: 25636
		private static readonly System.IntPtr NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0;

		// Token: 0x04006425 RID: 25637
		private static readonly System.IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x04006426 RID: 25638
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0;

		// Token: 0x04006427 RID: 25639
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04006428 RID: 25640
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B96 RID: 2966
		public sealed class PropertySelected : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600DE60 RID: 56928 RVA: 0x0034E7EC File Offset: 0x0034C9EC
			// Note: this type is marked as 'beforefieldinit'.
			static PropertySelected()
			{
				Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "PropertySelected");
				PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681757);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681758);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681759);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681760);
			}

			// Token: 0x0600DE61 RID: 56929 RVA: 0x0034E860 File Offset: 0x0034CA60
			[CallerCount(390)]
			[CachedScanResults(RefRangeStart = 108263, RefRangeEnd = 108653, XrefRangeStart = 108263, XrefRangeEnd = 108653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertySelected(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE62 RID: 56930 RVA: 0x0034E8BC File Offset: 0x0034CABC
			[CallerCount(0)]
			public unsafe void Invoke(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE63 RID: 56931 RVA: 0x0034E900 File Offset: 0x0034CB00
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Property p, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600DE64 RID: 56932 RVA: 0x0034E974 File Offset: 0x0034CB74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DE65 RID: 56933 RVA: 0x0006C025 File Offset: 0x0006A225
			public PropertySelected(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DE66 RID: 56934 RVA: 0x0006C02E File Offset: 0x0006A22E
			public static implicit operator PropertySelector.PropertySelected(System.Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<PropertySelector.PropertySelected>(A_0);
			}

			// Token: 0x0600DE67 RID: 56935 RVA: 0x0006C036 File Offset: 0x0006A236
			public static PropertySelector.PropertySelected operator +(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<PropertySelector.PropertySelected>();
			}

			// Token: 0x0600DE68 RID: 56936 RVA: 0x0006C044 File Offset: 0x0006A244
			public static PropertySelector.PropertySelected operator -(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PropertySelector.PropertySelected>();
				}
				return result;
			}

			// Token: 0x04009577 RID: 38263
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009578 RID: 38264
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x04009579 RID: 38265
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x0400957A RID: 38266
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
