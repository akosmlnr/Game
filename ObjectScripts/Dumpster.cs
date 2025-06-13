using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000781 RID: 1921
	public class Dumpster : GridItem
	{
		// Token: 0x0600B667 RID: 46695 RVA: 0x002DA9A8 File Offset: 0x002D8BA8
		// Note: this type is marked as 'beforefieldinit'.
		static Dumpster()
		{
			Il2CppClassPointerStore<Dumpster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Dumpster");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Dumpster>.NativeClassPtr);
			Dumpster.NativeFieldInfoPtr_capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "capacity");
			Dumpster.NativeFieldInfoPtr_lid_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_IntObj");
			Dumpster.NativeFieldInfoPtr_inner_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "inner_IntObj");
			Dumpster.NativeFieldInfoPtr_lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid");
			Dumpster.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash");
			Dumpster.NativeFieldInfoPtr_standPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "standPoint");
			Dumpster.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MinY");
			Dumpster.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "trash_MaxY");
			Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<lidOpen>k__BackingField");
			Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "<currentTrashLevel>k__BackingField");
			Dumpster.NativeFieldInfoPtr_lid_CurrentAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "lid_CurrentAngle");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.DumpsterAssembly-CSharp.dll_Excuted");
			Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685931);
			Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685932);
			Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685933);
			Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685934);
			Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685935);
			Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685936);
			Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685937);
			Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685938);
			Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685939);
			Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685940);
			Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685941);
			Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685942);
			Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685943);
			Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685944);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685946);
			Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685947);
			Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685948);
			Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Dumpster>.NativeClassPtr, 100685949);
		}

		// Token: 0x17003859 RID: 14425
		// (get) Token: 0x0600B668 RID: 46696 RVA: 0x002DAC44 File Offset: 0x002D8E44
		// (set) Token: 0x0600B669 RID: 46697 RVA: 0x002DAC80 File Offset: 0x002D8E80
		public unsafe bool lidOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700385A RID: 14426
		// (get) Token: 0x0600B66A RID: 46698 RVA: 0x002DACC0 File Offset: 0x002D8EC0
		// (set) Token: 0x0600B66B RID: 46699 RVA: 0x002DACFC File Offset: 0x002D8EFC
		public unsafe float currentTrashLevel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700385B RID: 14427
		// (get) Token: 0x0600B66C RID: 46700 RVA: 0x002DAD3C File Offset: 0x002D8F3C
		public unsafe bool isFull
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313746, XrefRangeEnd = 313750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x002DAD78 File Offset: 0x002D8F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313750, XrefRangeEnd = 313756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x002DADB4 File Offset: 0x002D8FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313756, XrefRangeEnd = 313763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Lid_Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x002DADF0 File Offset: 0x002D8FF0
		[CallerCount(0)]
		public unsafe virtual void Lid_Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x002DAE2C File Offset: 0x002D902C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313763, XrefRangeEnd = 313774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPlayerHaveBinEquipped()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x002DAE68 File Offset: 0x002D9068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313774, XrefRangeEnd = 313788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeTrashLevel(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x002DAEA8 File Offset: 0x002D90A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313788, XrefRangeEnd = 313802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTrashLevel(float trashLevel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref trashLevel;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x002DAEE8 File Offset: 0x002D90E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313802, XrefRangeEnd = 313811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x002DAF1C File Offset: 0x002D911C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313811, XrefRangeEnd = 313816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr il2CppString = 0;
			ptr2 = &il2CppString;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			reason = IL2CPP.Il2CppStringToManaged(il2CppString);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x002DAF80 File Offset: 0x002D9180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dumpster() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Dumpster>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Dumpster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x002DAFBC File Offset: 0x002D91BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313816, XrefRangeEnd = 313817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x002DAFF8 File Offset: 0x002D91F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 313817, XrefRangeEnd = 313818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x002DB034 File Offset: 0x002D9234
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B679 RID: 46713 RVA: 0x002DB070 File Offset: 0x002D9270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296649, RefRangeEnd = 296650, XrefRangeStart = 296649, XrefRangeEnd = 296650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Dumpster.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B67A RID: 46714 RVA: 0x0005916D File Offset: 0x0005736D
		public Dumpster(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600B67B RID: 46715 RVA: 0x002DB0AC File Offset: 0x002D92AC
		// (set) Token: 0x0600B67C RID: 46716 RVA: 0x00059176 File Offset: 0x00057376
		public unsafe static float capacity
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Dumpster.NativeFieldInfoPtr_capacity, (void*)(&value));
			}
		}

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600B67D RID: 46717 RVA: 0x002DB0C8 File Offset: 0x002D92C8
		// (set) Token: 0x0600B67E RID: 46718 RVA: 0x00059184 File Offset: 0x00057384
		public unsafe InteractableObject lid_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x002DB0F8 File Offset: 0x002D92F8
		// (set) Token: 0x0600B680 RID: 46720 RVA: 0x000591A3 File Offset: 0x000573A3
		public unsafe InteractableObject inner_IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_inner_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x002DB128 File Offset: 0x002D9328
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x000591C2 File Offset: 0x000573C2
		public unsafe Transform lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x002DB158 File Offset: 0x002D9358
		// (set) Token: 0x0600B684 RID: 46724 RVA: 0x000591E1 File Offset: 0x000573E1
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x002DB188 File Offset: 0x002D9388
		// (set) Token: 0x0600B686 RID: 46726 RVA: 0x00059200 File Offset: 0x00057400
		public unsafe Transform standPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_standPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B687 RID: 46727 RVA: 0x002DB1B8 File Offset: 0x002D93B8
		// (set) Token: 0x0600B688 RID: 46728 RVA: 0x0005921F File Offset: 0x0005741F
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B689 RID: 46729 RVA: 0x002DB1E0 File Offset: 0x002D93E0
		// (set) Token: 0x0600B68A RID: 46730 RVA: 0x0005923A File Offset: 0x0005743A
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B68B RID: 46731 RVA: 0x002DB208 File Offset: 0x002D9408
		// (set) Token: 0x0600B68C RID: 46732 RVA: 0x00059255 File Offset: 0x00057455
		public unsafe bool _lidOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__lidOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B68D RID: 46733 RVA: 0x002DB230 File Offset: 0x002D9430
		// (set) Token: 0x0600B68E RID: 46734 RVA: 0x00059270 File Offset: 0x00057470
		public unsafe float _currentTrashLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr__currentTrashLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x17003856 RID: 14422
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x002DB258 File Offset: 0x002D9458
		// (set) Token: 0x0600B690 RID: 46736 RVA: 0x0005928B File Offset: 0x0005748B
		public unsafe float lid_CurrentAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_lid_CurrentAngle)) = value;
			}
		}

		// Token: 0x17003857 RID: 14423
		// (get) Token: 0x0600B691 RID: 46737 RVA: 0x002DB280 File Offset: 0x002D9480
		// (set) Token: 0x0600B692 RID: 46738 RVA: 0x000592A6 File Offset: 0x000574A6
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003858 RID: 14424
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x002DB2A8 File Offset: 0x002D94A8
		// (set) Token: 0x0600B694 RID: 46740 RVA: 0x000592C1 File Offset: 0x000574C1
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Dumpster.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007B27 RID: 31527
		private static readonly IntPtr NativeFieldInfoPtr_capacity;

		// Token: 0x04007B28 RID: 31528
		private static readonly IntPtr NativeFieldInfoPtr_lid_IntObj;

		// Token: 0x04007B29 RID: 31529
		private static readonly IntPtr NativeFieldInfoPtr_inner_IntObj;

		// Token: 0x04007B2A RID: 31530
		private static readonly IntPtr NativeFieldInfoPtr_lid;

		// Token: 0x04007B2B RID: 31531
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x04007B2C RID: 31532
		private static readonly IntPtr NativeFieldInfoPtr_standPoint;

		// Token: 0x04007B2D RID: 31533
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x04007B2E RID: 31534
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x04007B2F RID: 31535
		private static readonly IntPtr NativeFieldInfoPtr__lidOpen_k__BackingField;

		// Token: 0x04007B30 RID: 31536
		private static readonly IntPtr NativeFieldInfoPtr__currentTrashLevel_k__BackingField;

		// Token: 0x04007B31 RID: 31537
		private static readonly IntPtr NativeFieldInfoPtr_lid_CurrentAngle;

		// Token: 0x04007B32 RID: 31538
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007B33 RID: 31539
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007B34 RID: 31540
		private static readonly IntPtr NativeMethodInfoPtr_get_lidOpen_Public_get_Boolean_0;

		// Token: 0x04007B35 RID: 31541
		private static readonly IntPtr NativeMethodInfoPtr_set_lidOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04007B36 RID: 31542
		private static readonly IntPtr NativeMethodInfoPtr_get_currentTrashLevel_Public_get_Single_0;

		// Token: 0x04007B37 RID: 31543
		private static readonly IntPtr NativeMethodInfoPtr_set_currentTrashLevel_Protected_set_Void_Single_0;

		// Token: 0x04007B38 RID: 31544
		private static readonly IntPtr NativeMethodInfoPtr_get_isFull_Public_get_Boolean_0;

		// Token: 0x04007B39 RID: 31545
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x04007B3A RID: 31546
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x04007B3B RID: 31547
		private static readonly IntPtr NativeMethodInfoPtr_Lid_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x04007B3C RID: 31548
		private static readonly IntPtr NativeMethodInfoPtr_DoesPlayerHaveBinEquipped_Protected_Boolean_0;

		// Token: 0x04007B3D RID: 31549
		private static readonly IntPtr NativeMethodInfoPtr_ChangeTrashLevel_Public_Void_Single_0;

		// Token: 0x04007B3E RID: 31550
		private static readonly IntPtr NativeMethodInfoPtr_SetTrashLevel_Public_Void_Single_0;

		// Token: 0x04007B3F RID: 31551
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Private_Void_0;

		// Token: 0x04007B40 RID: 31552
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04007B41 RID: 31553
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007B42 RID: 31554
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007B43 RID: 31555
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007B44 RID: 31556
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007B45 RID: 31557
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
