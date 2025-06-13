using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C6 RID: 1734
	public class AppsCanvas : PlayerSingleton<AppsCanvas>
	{
		// Token: 0x06009A00 RID: 39424 RVA: 0x00277C94 File Offset: 0x00275E94
		// Note: this type is marked as 'beforefieldinit'.
		static AppsCanvas()
		{
			Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "AppsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr);
			AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<isOpen>k__BackingField");
			AppsCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "canvas");
			AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "delayedSetOpenRoutine");
			AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682391);
			AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682392);
			AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682393);
			AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682394);
			AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682395);
			AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682396);
			AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682397);
			AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682398);
			AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682399);
			AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682400);
			AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, 100682401);
		}

		// Token: 0x17002F0F RID: 12047
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x00277DDC File Offset: 0x00275FDC
		// (set) Token: 0x06009A02 RID: 39426 RVA: 0x00277E18 File Offset: 0x00276018
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009A03 RID: 39427 RVA: 0x00277E58 File Offset: 0x00276058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275483, XrefRangeEnd = 275489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A04 RID: 39428 RVA: 0x00277E94 File Offset: 0x00276094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275489, XrefRangeEnd = 275520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient(bool IsOwner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref IsOwner;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A05 RID: 39429 RVA: 0x00277EE0 File Offset: 0x002760E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275520, XrefRangeEnd = 275522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneOpened()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneOpened_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A06 RID: 39430 RVA: 0x00277F14 File Offset: 0x00276114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275522, XrefRangeEnd = 275529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClosed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_PhoneClosed_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A07 RID: 39431 RVA: 0x00277F48 File Offset: 0x00276148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275529, XrefRangeEnd = 275534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref delay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06009A08 RID: 39432 RVA: 0x00277FA4 File Offset: 0x002761A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275537, RefRangeEnd = 275538, XrefRangeStart = 275534, XrefRangeEnd = 275537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref o;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A09 RID: 39433 RVA: 0x00277FE4 File Offset: 0x002761E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275538, XrefRangeEnd = 275541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A0A RID: 39434 RVA: 0x00278024 File Offset: 0x00276224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275541, XrefRangeEnd = 275550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AppsCanvas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A0B RID: 39435 RVA: 0x00278060 File Offset: 0x00276260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275550, XrefRangeEnd = 275553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AppsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A0C RID: 39436 RVA: 0x0004AAD5 File Offset: 0x00048CD5
		public AppsCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F0C RID: 12044
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x0027809C File Offset: 0x0027629C
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x0004AADE File Offset: 0x00048CDE
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F0D RID: 12045
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x002780C4 File Offset: 0x002762C4
		// (set) Token: 0x06009A10 RID: 39440 RVA: 0x0004AAF9 File Offset: 0x00048CF9
		public unsafe Canvas canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F0E RID: 12046
		// (get) Token: 0x06009A11 RID: 39441 RVA: 0x002780F4 File Offset: 0x002762F4
		// (set) Token: 0x06009A12 RID: 39442 RVA: 0x0004AB18 File Offset: 0x00048D18
		public unsafe Coroutine delayedSetOpenRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas.NativeFieldInfoPtr_delayedSetOpenRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067C4 RID: 26564
		private static readonly System.IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x040067C5 RID: 26565
		private static readonly System.IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x040067C6 RID: 26566
		private static readonly System.IntPtr NativeFieldInfoPtr_delayedSetOpenRoutine;

		// Token: 0x040067C7 RID: 26567
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x040067C8 RID: 26568
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isOpen_Private_set_Void_Boolean_0;

		// Token: 0x040067C9 RID: 26569
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040067CA RID: 26570
		private static readonly System.IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_Boolean_0;

		// Token: 0x040067CB RID: 26571
		private static readonly System.IntPtr NativeMethodInfoPtr_PhoneOpened_Protected_Void_0;

		// Token: 0x040067CC RID: 26572
		private static readonly System.IntPtr NativeMethodInfoPtr_PhoneClosed_Protected_Void_0;

		// Token: 0x040067CD RID: 26573
		private static readonly System.IntPtr NativeMethodInfoPtr_DelayedSetCanvasActive_Private_IEnumerator_Boolean_Single_0;

		// Token: 0x040067CE RID: 26574
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_0;

		// Token: 0x040067CF RID: 26575
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanvasActive_Private_Void_Boolean_0;

		// Token: 0x040067D0 RID: 26576
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040067D1 RID: 26577
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BB8 RID: 3000
		[ObfuscatedName("ScheduleOne.UI.Phone.AppsCanvas+<DelayedSetCanvasActive>d__10")]
		public sealed class _DelayedSetCanvasActive_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DFC1 RID: 57281 RVA: 0x00352A54 File Offset: 0x00350C54
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSetCanvasActive_d__10()
			{
				Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AppsCanvas>.NativeClassPtr, "<DelayedSetCanvasActive>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>1__state");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>2__current");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "delay");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "<>4__this");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, "active");
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682402);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682403);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682404);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682405);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682406);
				AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr, 100682407);
			}

			// Token: 0x0600DFC2 RID: 57282 RVA: 0x00352B5C File Offset: 0x00350D5C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSetCanvasActive_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AppsCanvas._DelayedSetCanvasActive_d__10>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFC3 RID: 57283 RVA: 0x00352BA4 File Offset: 0x00350DA4
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFC4 RID: 57284 RVA: 0x00352BD8 File Offset: 0x00350DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275473, XrefRangeEnd = 275478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004519 RID: 17689
			// (get) Token: 0x0600DFC5 RID: 57285 RVA: 0x00352C14 File Offset: 0x00350E14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DFC6 RID: 57286 RVA: 0x00352C54 File Offset: 0x00350E54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275478, XrefRangeEnd = 275483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x1700451A RID: 17690
			// (get) Token: 0x0600DFC7 RID: 57287 RVA: 0x00352C88 File Offset: 0x00350E88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppsCanvas._DelayedSetCanvasActive_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DFC8 RID: 57288 RVA: 0x0006CA08 File Offset: 0x0006AC08
			public _DelayedSetCanvasActive_d__10(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004514 RID: 17684
			// (get) Token: 0x0600DFC9 RID: 57289 RVA: 0x00352CC8 File Offset: 0x00350EC8
			// (set) Token: 0x0600DFCA RID: 57290 RVA: 0x0006CA11 File Offset: 0x0006AC11
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004515 RID: 17685
			// (get) Token: 0x0600DFCB RID: 57291 RVA: 0x00352CF0 File Offset: 0x00350EF0
			// (set) Token: 0x0600DFCC RID: 57292 RVA: 0x0006CA2C File Offset: 0x0006AC2C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004516 RID: 17686
			// (get) Token: 0x0600DFCD RID: 57293 RVA: 0x00352D20 File Offset: 0x00350F20
			// (set) Token: 0x0600DFCE RID: 57294 RVA: 0x0006CA4B File Offset: 0x0006AC4B
			public unsafe float delay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004517 RID: 17687
			// (get) Token: 0x0600DFCF RID: 57295 RVA: 0x00352D48 File Offset: 0x00350F48
			// (set) Token: 0x0600DFD0 RID: 57296 RVA: 0x0006CA66 File Offset: 0x0006AC66
			public unsafe AppsCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AppsCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004518 RID: 17688
			// (get) Token: 0x0600DFD1 RID: 57297 RVA: 0x00352D78 File Offset: 0x00350F78
			// (set) Token: 0x0600DFD2 RID: 57298 RVA: 0x0006CA85 File Offset: 0x0006AC85
			public unsafe bool active
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AppsCanvas._DelayedSetCanvasActive_d__10.NativeFieldInfoPtr_active)) = value;
				}
			}

			// Token: 0x04009640 RID: 38464
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009641 RID: 38465
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009642 RID: 38466
			private static readonly System.IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04009643 RID: 38467
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009644 RID: 38468
			private static readonly System.IntPtr NativeFieldInfoPtr_active;

			// Token: 0x04009645 RID: 38469
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009646 RID: 38470
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009647 RID: 38471
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009648 RID: 38472
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009649 RID: 38473
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400964A RID: 38474
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
