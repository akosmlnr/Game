using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C8 RID: 1736
	public class CallNotification : Singleton<CallNotification>
	{
		// Token: 0x06009A4C RID: 39500 RVA: 0x00278BDC File Offset: 0x00276DDC
		// Note: this type is marked as 'beforefieldinit'.
		static CallNotification()
		{
			Il2CppClassPointerStore<CallNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification>.NativeClassPtr);
			CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "TIME_PER_CHAR");
			CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallNotification.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Container");
			CallNotification.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "ProfilePicture");
			CallNotification.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "Group");
			CallNotification.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "slideRoutine");
			CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682433);
			CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682434);
			CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682435);
			CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682436);
			CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682437);
			CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682438);
			CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, 100682439);
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x06009A4D RID: 39501 RVA: 0x00278D24 File Offset: 0x00276F24
		// (set) Token: 0x06009A4E RID: 39502 RVA: 0x00278D64 File Offset: 0x00276F64
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F2D RID: 12077
		// (get) Token: 0x06009A4F RID: 39503 RVA: 0x00278DA8 File Offset: 0x00276FA8
		// (set) Token: 0x06009A50 RID: 39504 RVA: 0x00278DE4 File Offset: 0x00276FE4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x00278E24 File Offset: 0x00277024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275897, XrefRangeEnd = 275905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallNotification.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x00278E60 File Offset: 0x00277060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275905, XrefRangeEnd = 275920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOpen(bool visible, CallerID caller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x00278EB0 File Offset: 0x002770B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275920, XrefRangeEnd = 275923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallNotification() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x0004AD6C File Offset: 0x00048F6C
		public CallNotification(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x06009A55 RID: 39509 RVA: 0x00278EEC File Offset: 0x002770EC
		// (set) Token: 0x06009A56 RID: 39510 RVA: 0x0004AD75 File Offset: 0x00048F75
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallNotification.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x06009A57 RID: 39511 RVA: 0x00278F08 File Offset: 0x00277108
		// (set) Token: 0x06009A58 RID: 39512 RVA: 0x0004AD83 File Offset: 0x00048F83
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x06009A59 RID: 39513 RVA: 0x00278F38 File Offset: 0x00277138
		// (set) Token: 0x06009A5A RID: 39514 RVA: 0x0004ADA2 File Offset: 0x00048FA2
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x06009A5B RID: 39515 RVA: 0x00278F60 File Offset: 0x00277160
		// (set) Token: 0x06009A5C RID: 39516 RVA: 0x0004ADBD File Offset: 0x00048FBD
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x06009A5D RID: 39517 RVA: 0x00278F90 File Offset: 0x00277190
		// (set) Token: 0x06009A5E RID: 39518 RVA: 0x0004ADDC File Offset: 0x00048FDC
		public unsafe Image ProfilePicture
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x06009A5F RID: 39519 RVA: 0x00278FC0 File Offset: 0x002771C0
		// (set) Token: 0x06009A60 RID: 39520 RVA: 0x0004ADFB File Offset: 0x00048FFB
		public unsafe CanvasGroup Group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x06009A61 RID: 39521 RVA: 0x00278FF0 File Offset: 0x002771F0
		// (set) Token: 0x06009A62 RID: 39522 RVA: 0x0004AE1A File Offset: 0x0004901A
		public unsafe Coroutine slideRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067F6 RID: 26614
		private static readonly System.IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x040067F7 RID: 26615
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x040067F8 RID: 26616
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040067F9 RID: 26617
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040067FA RID: 26618
		private static readonly System.IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x040067FB RID: 26619
		private static readonly System.IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x040067FC RID: 26620
		private static readonly System.IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x040067FD RID: 26621
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x040067FE RID: 26622
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x040067FF RID: 26623
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006800 RID: 26624
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006801 RID: 26625
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006802 RID: 26626
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Void_Boolean_CallerID_0;

		// Token: 0x04006803 RID: 26627
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BBA RID: 3002
		[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFDD RID: 57309 RVA: 0x00352F2C File Offset: 0x0035112C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr);
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "visible");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "caller");
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100682440);
				CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, 100682441);
			}

			// Token: 0x0600DFDE RID: 57310 RVA: 0x00352FBC File Offset: 0x003511BC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFDF RID: 57311 RVA: 0x00352FF8 File Offset: 0x003511F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275892, XrefRangeEnd = 275897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DFE0 RID: 57312 RVA: 0x0006CAFE File Offset: 0x0006ACFE
			public __c__DisplayClass14_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700451E RID: 17694
			// (get) Token: 0x0600DFE1 RID: 57313 RVA: 0x00353038 File Offset: 0x00351238
			// (set) Token: 0x0600DFE2 RID: 57314 RVA: 0x0006CB07 File Offset: 0x0006AD07
			public unsafe bool visible
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x1700451F RID: 17695
			// (get) Token: 0x0600DFE3 RID: 57315 RVA: 0x00353060 File Offset: 0x00351260
			// (set) Token: 0x0600DFE4 RID: 57316 RVA: 0x0006CB22 File Offset: 0x0006AD22
			public unsafe CallNotification __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004520 RID: 17696
			// (get) Token: 0x0600DFE5 RID: 57317 RVA: 0x00353090 File Offset: 0x00351290
			// (set) Token: 0x0600DFE6 RID: 57318 RVA: 0x0006CB41 File Offset: 0x0006AD41
			public unsafe CallerID caller
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.NativeFieldInfoPtr_caller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009650 RID: 38480
			private static readonly System.IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x04009651 RID: 38481
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009652 RID: 38482
			private static readonly System.IntPtr NativeFieldInfoPtr_caller;

			// Token: 0x04009653 RID: 38483
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009654 RID: 38484
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD8 RID: 3288
			[ObfuscatedName("ScheduleOne.UI.Phone.CallNotification+<>c__DisplayClass14_0+<<SetIsOpen>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EBB8 RID: 60344 RVA: 0x00374F20 File Offset: 0x00373120
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique()
				{
					Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0>.NativeClassPtr, "<<SetIsOpen>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>1__state");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>2__current");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>4__this");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startX>5__2");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endX>5__3");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startAlpha>5__4");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endAlpha>5__5");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<lerpTime>5__6");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<i>5__7");
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682442);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682443);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682444);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682445);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682446);
					CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682447);
				}

				// Token: 0x0600EBB9 RID: 60345 RVA: 0x00375078 File Offset: 0x00373278
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBBA RID: 60346 RVA: 0x003750C0 File Offset: 0x003732C0
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBBB RID: 60347 RVA: 0x003750F4 File Offset: 0x003732F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275859, XrefRangeEnd = 275887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700490F RID: 18703
				// (get) Token: 0x0600EBBC RID: 60348 RVA: 0x00375130 File Offset: 0x00373330
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBBD RID: 60349 RVA: 0x00375170 File Offset: 0x00373370
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275887, XrefRangeEnd = 275892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004910 RID: 18704
				// (get) Token: 0x0600EBBE RID: 60350 RVA: 0x003751A4 File Offset: 0x003733A4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBBF RID: 60351 RVA: 0x00072B60 File Offset: 0x00070D60
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004906 RID: 18694
				// (get) Token: 0x0600EBC0 RID: 60352 RVA: 0x003751E4 File Offset: 0x003733E4
				// (set) Token: 0x0600EBC1 RID: 60353 RVA: 0x00072B69 File Offset: 0x00070D69
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004907 RID: 18695
				// (get) Token: 0x0600EBC2 RID: 60354 RVA: 0x0037520C File Offset: 0x0037340C
				// (set) Token: 0x0600EBC3 RID: 60355 RVA: 0x00072B84 File Offset: 0x00070D84
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004908 RID: 18696
				// (get) Token: 0x0600EBC4 RID: 60356 RVA: 0x0037523C File Offset: 0x0037343C
				// (set) Token: 0x0600EBC5 RID: 60357 RVA: 0x00072BA3 File Offset: 0x00070DA3
				public unsafe CallNotification.__c__DisplayClass14_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallNotification.__c__DisplayClass14_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004909 RID: 18697
				// (get) Token: 0x0600EBC6 RID: 60358 RVA: 0x0037526C File Offset: 0x0037346C
				// (set) Token: 0x0600EBC7 RID: 60359 RVA: 0x00072BC2 File Offset: 0x00070DC2
				public unsafe float _startX_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x1700490A RID: 18698
				// (get) Token: 0x0600EBC8 RID: 60360 RVA: 0x00375294 File Offset: 0x00373494
				// (set) Token: 0x0600EBC9 RID: 60361 RVA: 0x00072BDD File Offset: 0x00070DDD
				public unsafe float _endX_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endX_5__3)) = value;
					}
				}

				// Token: 0x1700490B RID: 18699
				// (get) Token: 0x0600EBCA RID: 60362 RVA: 0x003752BC File Offset: 0x003734BC
				// (set) Token: 0x0600EBCB RID: 60363 RVA: 0x00072BF8 File Offset: 0x00070DF8
				public unsafe float _startAlpha_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__4)) = value;
					}
				}

				// Token: 0x1700490C RID: 18700
				// (get) Token: 0x0600EBCC RID: 60364 RVA: 0x003752E4 File Offset: 0x003734E4
				// (set) Token: 0x0600EBCD RID: 60365 RVA: 0x00072C13 File Offset: 0x00070E13
				public unsafe float _endAlpha_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__5)) = value;
					}
				}

				// Token: 0x1700490D RID: 18701
				// (get) Token: 0x0600EBCE RID: 60366 RVA: 0x0037530C File Offset: 0x0037350C
				// (set) Token: 0x0600EBCF RID: 60367 RVA: 0x00072C2E File Offset: 0x00070E2E
				public unsafe float _lerpTime_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6)) = value;
					}
				}

				// Token: 0x1700490E RID: 18702
				// (get) Token: 0x0600EBD0 RID: 60368 RVA: 0x00375334 File Offset: 0x00373534
				// (set) Token: 0x0600EBD1 RID: 60369 RVA: 0x00072C49 File Offset: 0x00070E49
				public unsafe float _i_5__7
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallNotification.__c__DisplayClass14_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7)) = value;
					}
				}

				// Token: 0x04009D9E RID: 40350
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D9F RID: 40351
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009DA0 RID: 40352
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009DA1 RID: 40353
				private static readonly System.IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x04009DA2 RID: 40354
				private static readonly System.IntPtr NativeFieldInfoPtr__endX_5__3;

				// Token: 0x04009DA3 RID: 40355
				private static readonly System.IntPtr NativeFieldInfoPtr__startAlpha_5__4;

				// Token: 0x04009DA4 RID: 40356
				private static readonly System.IntPtr NativeFieldInfoPtr__endAlpha_5__5;

				// Token: 0x04009DA5 RID: 40357
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__6;

				// Token: 0x04009DA6 RID: 40358
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__7;

				// Token: 0x04009DA7 RID: 40359
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009DA8 RID: 40360
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DA9 RID: 40361
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009DAA RID: 40362
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009DAB RID: 40363
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009DAC RID: 40364
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
