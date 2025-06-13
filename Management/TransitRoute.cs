using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C7 RID: 967
	public class TransitRoute : Il2CppSystem.Object
	{
		// Token: 0x06004AA8 RID: 19112 RVA: 0x0016D690 File Offset: 0x0016B890
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRoute()
		{
			Il2CppClassPointerStore<TransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr);
			TransitRoute.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Source>k__BackingField");
			TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Destination>k__BackingField");
			TransitRoute.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "visuals");
			TransitRoute.NativeFieldInfoPtr_onSourceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onSourceChange");
			TransitRoute.NativeFieldInfoPtr_onDestinationChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onDestinationChange");
			TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672631);
			TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672632);
			TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672633);
			TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672634);
			TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672635);
			TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672636);
			TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672637);
			TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672638);
			TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672639);
			TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672640);
			TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672641);
			TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672642);
		}

		// Token: 0x17001646 RID: 5702
		// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x0016D814 File Offset: 0x0016BA14
		// (set) Token: 0x06004AAA RID: 19114 RVA: 0x0016D854 File Offset: 0x0016BA54
		public unsafe ITransitEntity Source
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 18697, RefRangeEnd = 18709, XrefRangeStart = 18697, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 31460, RefRangeEnd = 31462, XrefRangeStart = 31460, XrefRangeEnd = 31462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001647 RID: 5703
		// (get) Token: 0x06004AAB RID: 19115 RVA: 0x0016D898 File Offset: 0x0016BA98
		// (set) Token: 0x06004AAC RID: 19116 RVA: 0x0016D8D8 File Offset: 0x0016BAD8
		public unsafe ITransitEntity Destination
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x0016D91C File Offset: 0x0016BB1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167625, RefRangeEnd = 167629, XrefRangeStart = 167604, XrefRangeEnd = 167625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x0016D97C File Offset: 0x0016BB7C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 167652, RefRangeEnd = 167668, XrefRangeStart = 167629, XrefRangeEnd = 167652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x0016D9B0 File Offset: 0x0016BBB0
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 167693, RefRangeEnd = 167709, XrefRangeStart = 167668, XrefRangeEnd = 167693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref active;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x0016D9F0 File Offset: 0x0016BBF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 167732, RefRangeEnd = 167733, XrefRangeStart = 167709, XrefRangeEnd = 167732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AB1 RID: 19121 RVA: 0x0016DA24 File Offset: 0x0016BC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167733, XrefRangeEnd = 167734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSource(ITransitEntity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x0016DA74 File Offset: 0x0016BC74
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 167735, RefRangeEnd = 167739, XrefRangeStart = 167734, XrefRangeEnd = 167735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreEntitiesNonNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x0016DAB0 File Offset: 0x0016BCB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167739, XrefRangeEnd = 167740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDestination(ITransitEntity destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x0016DB00 File Offset: 0x0016BD00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167745, RefRangeEnd = 167747, XrefRangeStart = 167740, XrefRangeEnd = 167745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AB5 RID: 19125 RVA: 0x00023CEC File Offset: 0x00021EEC
		public TransitRoute(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001641 RID: 5697
		// (get) Token: 0x06004AB6 RID: 19126 RVA: 0x0016DB34 File Offset: 0x0016BD34
		// (set) Token: 0x06004AB7 RID: 19127 RVA: 0x00023CF5 File Offset: 0x00021EF5
		public unsafe ITransitEntity _Source_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001642 RID: 5698
		// (get) Token: 0x06004AB8 RID: 19128 RVA: 0x0016DB64 File Offset: 0x0016BD64
		// (set) Token: 0x06004AB9 RID: 19129 RVA: 0x00023D14 File Offset: 0x00021F14
		public unsafe ITransitEntity _Destination_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001643 RID: 5699
		// (get) Token: 0x06004ABA RID: 19130 RVA: 0x0016DB94 File Offset: 0x0016BD94
		// (set) Token: 0x06004ABB RID: 19131 RVA: 0x00023D33 File Offset: 0x00021F33
		public unsafe TransitLineVisuals visuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001644 RID: 5700
		// (get) Token: 0x06004ABC RID: 19132 RVA: 0x0016DBC4 File Offset: 0x0016BDC4
		// (set) Token: 0x06004ABD RID: 19133 RVA: 0x00023D52 File Offset: 0x00021F52
		public unsafe Il2CppSystem.Action<ITransitEntity> onSourceChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001645 RID: 5701
		// (get) Token: 0x06004ABE RID: 19134 RVA: 0x0016DBF4 File Offset: 0x0016BDF4
		// (set) Token: 0x06004ABF RID: 19135 RVA: 0x00023D71 File Offset: 0x00021F71
		public unsafe Il2CppSystem.Action<ITransitEntity> onDestinationChange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003255 RID: 12885
		private static readonly System.IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x04003256 RID: 12886
		private static readonly System.IntPtr NativeFieldInfoPtr__Destination_k__BackingField;

		// Token: 0x04003257 RID: 12887
		private static readonly System.IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x04003258 RID: 12888
		private static readonly System.IntPtr NativeFieldInfoPtr_onSourceChange;

		// Token: 0x04003259 RID: 12889
		private static readonly System.IntPtr NativeFieldInfoPtr_onDestinationChange;

		// Token: 0x0400325A RID: 12890
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0;

		// Token: 0x0400325B RID: 12891
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0;

		// Token: 0x0400325C RID: 12892
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0;

		// Token: 0x0400325D RID: 12893
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0;

		// Token: 0x0400325E RID: 12894
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x0400325F RID: 12895
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04003260 RID: 12896
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0;

		// Token: 0x04003261 RID: 12897
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003262 RID: 12898
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003263 RID: 12899
		private static readonly System.IntPtr NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0;

		// Token: 0x04003264 RID: 12900
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003265 RID: 12901
		private static readonly System.IntPtr NativeMethodInfoPtr_ValidateEntities_Private_Void_0;
	}
}
